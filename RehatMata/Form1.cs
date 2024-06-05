namespace RehatMata
{
    public partial class Form1 : Form
    {
        bool _running = false;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Stop")
            {
                btnStart.Text = "Mulai";
                _running = false;
                return;
            }

            if (String.IsNullOrWhiteSpace(txtbDepanLayar.Text) ||
                String.IsNullOrWhiteSpace(txtbIstirahat.Text) ||
                (!radioTakTerbatas.Checked && !radioUlangiSetiap.Checked))
            {
                MessageBox.Show("Harap Isi Semua Field!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _running = true;
            btnStart.Text = "Stop";



            int waktuDepanLayar = Convert.ToInt32(txtbDepanLayar.Text) * 1000;
            int waktuIstirahat = Convert.ToInt32(txtbIstirahat.Text) * 1000;
            int ulangiSetiap = 0;

            if (radioUlangiSetiap.Checked)
            {
                await Task.Run(() => JalankanSetiapInverval(waktuDepanLayar, waktuIstirahat, ulangiSetiap));
            }

            else if (radioTakTerbatas.Checked)
            {
                await Task.Run(() => JalankanTakTerbatas(waktuDepanLayar, waktuIstirahat));
            }
        }

        private async void JalankanSetiapInverval(int waktuDepanLayar, int waktuIstirahat, int intreval)
        {
            for (int i = 0; i <= intreval; i++)
            {
                await Task.Delay(waktuDepanLayar);

                DialogResult result = MessageBox.Show("Waktunya Istirahat! Tunggu Notifikasi Selanjutnya!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                switch (result)
                {
                    case DialogResult.OK:
                        await Task.Delay(waktuIstirahat);
                        break;
                    default:
                        break;
                }

                MessageBox.Show("Silahkan Lanjut Bekerja!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private async void JalankanTakTerbatas(int waktuDepanLayar, int waktuIstirahat)
        {
            while (_running)
            {
                await Task.Delay(waktuDepanLayar);

                DialogResult result = MessageBox.Show("Waktunya Istirahat! Tunggu Notifikasi Selanjutnya!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                switch (result)
                {
                    case DialogResult.OK:
                        await Task.Delay(waktuIstirahat);
                        break;
                    default:
                        break;
                }

                MessageBox.Show("Silahkan Lanjut Bekerja!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void txtbDepanLayar_TextChanged(object sender, EventArgs e)
        {
            int cekValue = 0;

            if (!String.IsNullOrWhiteSpace(txtbDepanLayar.Text) && !int.TryParse(txtbDepanLayar.Text, out cekValue))
            {
                MessageBox.Show("Harap Masukkan Angka!");
                return;
            }
        }

        private void txtbIstirahat_TextChanged(object sender, EventArgs e)
        {
            int cekValue = 0;

            if (!String.IsNullOrWhiteSpace(txtbIstirahat.Text) && !int.TryParse(txtbIstirahat.Text, out cekValue))
            {
                MessageBox.Show("Harap Masukkan Angka!");
                return;
            }
        }
    }
}