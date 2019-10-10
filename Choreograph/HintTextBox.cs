using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choreograph
{
    public partial class HintTextBox : TextBox, INotifyPropertyChanged
    {
        private DataSourceUpdateMode _source_update_mode = DataSourceUpdateMode.OnValidation;
        public DataSourceUpdateMode SourceUpdateMode {
            get { return _source_update_mode; }
            set { _source_update_mode = value; }
        }
        public Unfocus Unfocus = null;
        private Color starting_forecolour;
        public Color HintForecolor = Color.Gray;
        private bool hint_active = false;
        private string _hint = "";
        public string Hint {
            get { return _hint; }
            set {
                _hint = value;
                if (!show_hint())
                {
                    disable_hint();
                }
            }
        }
        private string _text = "";

        public new string Text {
            get => _text;
            set {
                if (_text != value)
                {
                    if (value == null)
                    {
                        _text = "";
                    }
                    else
                    {
                        _text = value;
                        OnPropertyChanged(nameof(Text));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string property_name)
        {
            PropertyChangedEventHandler property_changed = PropertyChanged;
            if (property_changed != null)
            {
                property_changed(this, new PropertyChangedEventArgs(property_name));
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!hint_active)
            {
                Text = base.Text;
            }
            base.OnTextChanged(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            if (SourceUpdateMode == DataSourceUpdateMode.OnValidation)
            {
                push_text_change();
            }
            base.OnValidated(e);
        }

        private void push_text_change()
        {
            foreach (Binding binding in DataBindings)
            {
                if (binding.PropertyName == nameof(Text))
                {
                    binding.WriteValue();

                    // This is very bad but WriteValue alone doesn't notify changes
                    Storage.characters.AcceptChanges();
                }
            }
        }

        private void handle_property_changed(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Text))
            {
                if (!show_hint())
                {
                    disable_hint();
                }
                
                if (SourceUpdateMode == DataSourceUpdateMode.OnPropertyChanged)
                {
                    push_text_change();
                }
            }
        }

        private void setup()
        {
            InitializeComponent();
            starting_forecolour = ForeColor;
            this.PropertyChanged += handle_property_changed;
            this.Enter += textBox1_Enter;
            this.Validated += textBox1_Leave;

            AutoSize = false;
            Location = new Point(0, 0);
            Size = this.Size;
            Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            ForeColor = HintForecolor;

            show_hint();
        }

        public HintTextBox()
        {
            setup();
        }

        public HintTextBox(Unfocus unfocus)
        {
            Unfocus = unfocus;
            setup();
        }

        private void enable_hint()
        {
            hint_active = true;
            ForeColor = HintForecolor;
            base.Text = Hint;
        }

        private void disable_hint()
        {
            ForeColor = starting_forecolour;
            base.Text = Text;
            hint_active = false;
        }

        private bool show_hint()
        {
            if (!Focused && Text.Trim() == "" && Hint.Trim() != "")
            {
                enable_hint();
                return true;
            }
            return false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            show_hint();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            disable_hint();
        }

        private void HintTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                if (Unfocus != null)
                {
                    Unfocus();
                }
                if (SourceUpdateMode == DataSourceUpdateMode.OnValidation)
                {
                    push_text_change();
                }
            }
        }
    }
}
