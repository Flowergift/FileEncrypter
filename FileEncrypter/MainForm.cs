namespace FileEncrypter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Encrypt_button_Click(object sender, EventArgs e)
        {
            Encrypter encrypter = new Encrypter();  
            encrypter. ShowDialog();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            Decrypter decrypter = new Decrypter();
            decrypter.ShowDialog();
        }
    }
}