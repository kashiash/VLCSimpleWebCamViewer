namespace KeysConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  MessageBox.Show(e.KeyChar.ToString() +' ' + e.keyco , "KeyPress");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString(), "KeyDown");

            KeysConverter kc = new KeysConverter();
            // MessageBox.Show(kc.ConvertToString(e.KeyCode), "KeyDown");
            var sc = Shortcut.CtrlShiftF1;
            var txt = new KeysConverter().ConvertToString((Keys)sc);
        Console.WriteLine(txt);
            if (e.KeyCode == (Keys)sc)
            {
                Console.WriteLine($"wcisnieto {txt}");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) 
        {
            if (keyData == (Keys)(Shortcut.CtrlShiftK)) // (Keys.K | Keys.Shift | Keys.Control) == (Keys)(Shortcut.CtrlShiftK
            {
                MessageBox.Show($" Combination pressed {(int)(Keys.K | Keys.Shift| Keys.Control)} {(int)(Shortcut.CtrlShiftK)}");
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
    }