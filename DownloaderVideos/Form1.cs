using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using VideoLibrary;
using System.Net;
using System.IO;

namespace DownloaderVideos
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        BackgroundWorker bw = new BackgroundWorker();
        FileStream stream;
        Video video;
        String caminho;

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            D.ForeColor = Color.FromArgb(0, 135, 247);
            download.ForeColor = Color.FromArgb(0, 135, 247);
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download concluído", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progresso.Value = e.ProgressPercentage;
            labelPorcentagem.Text = e.ProgressPercentage + "%";
        }

        private List<string> FormatosVideo()
        {
            List<string> listaFormatos;
            listaFormatos = new List<string>();
            listaFormatos.Add("MP4");
            listaFormatos.Add("WMV");
            listaFormatos.Add("AVI");
            return listaFormatos;
        }

        private List<string> FormatosAudio()
        {
            List<string> listaFormatos;
            listaFormatos = new List<string>();
            listaFormatos.Add("MP3");
            listaFormatos.Add("WMA");
            listaFormatos.Add("WAV");
            return listaFormatos;
        }

        private void Limpar()
        {
            txtLink.Clear();
            txtLocalDestino.Clear();
            labelMensagem.ResetText();
            progresso.Value = 0;
            labelPorcentagem.ResetText();
            cmbFormatos.DataSource = null;
            chkBoxAudio.Checked = false;
            chkBoxVideo.Checked = true;
        }

        private void BotaoCancelarHabilitado()
        {
            btnCancelar.Enabled = true;
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
        }

        private void BotaoCancelarDesabilitado()
        {
            btnCancelar.Enabled = false;
            btnCancelar.BackColor = Color.LightGray;
            btnCancelar.ForeColor = Color.Gray;
        }

        private void BotaoBaixarHabilitado()
        {
            btnBaixar.Enabled = true;
            btnBaixar.BackColor = Color.DarkCyan;
            btnBaixar.ForeColor = Color.White;
        }

        private void BotaoBaixarDesabilitado()
        {
            btnBaixar.Enabled = false;
            btnBaixar.BackColor = Color.LightGray;
            btnBaixar.ForeColor = Color.Gray;
        }

        private async void BaixarVideo()
        {
            if (txtLink.Text.Equals(""))
            {
                MessageBox.Show("Informe o link para download", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLocalDestino.Text.Equals(""))
            {
                MessageBox.Show("Informe o local de saída", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chkBoxVideo.Checked == false && chkBoxAudio.Checked == false)
            {
                MessageBox.Show("Escolha o tipo de arquivo a ser baixado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BotaoBaixarDesabilitado();
                BotaoCancelarHabilitado();
                try
                {
                    Uri url = new Uri(txtLink.Text);
                    var youTube = YouTube.Default;
                    video = youTube.GetVideo(url.ToString());
                    caminho = txtLocalDestino.Text + @"/" + video.Title + "." + cmbFormatos.Text.ToLower();
                    double tamanho = video.GetBytes().Length;

                    using (stream = File.Open(caminho, FileMode.OpenOrCreate))
                    {
                        for (int i = 0; i <= progresso.Maximum; i += 8)
                        {
                            labelMensagem.Text = "Fazendo o download...";
                            //stream.SetLength((long)tamanho);
                            progresso.Value = i;
                            labelPorcentagem.Text = progresso.Value + " %";
                            stream.Seek(0, SeekOrigin.End);
                            await stream.WriteAsync(video.GetBytes(), 0, Convert.ToInt32(tamanho));
                        }
                        labelMensagem.BeginInvoke(new Action(() =>
                        {
                            double tamanhoConvertidoMB = (tamanho / 1024) / 1024;
                            labelMensagem.Text = "Tamanho do arquivo: " + tamanhoConvertidoMB + "MB";
                            MessageBox.Show("Download concluído!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BotaoBaixarHabilitado();
                            BotaoCancelarDesabilitado();
                            Limpar();
                        }
                        ));
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Caracteres inválidos no caminho." || ex.Message.Substring(0, 21) == "GetDecryptionFunction")
                    {
                        MessageBox.Show("Este vídeo não tem permissão para ser baixado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BotaoBaixarHabilitado();
                        BotaoCancelarDesabilitado();
                    }
                    else if (ex.Message.Substring(0,26) == "Não foi possível localizar")
                    {
                        MessageBox.Show("Local de saída inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BotaoBaixarHabilitado();
                        BotaoCancelarDesabilitado();
                    }
                }
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            BaixarVideo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (salvarArquivo.ShowDialog() == DialogResult.OK)
            {
                txtLocalDestino.Text = salvarArquivo.SelectedPath;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            stream.Close();
            MessageBox.Show("Download cancelado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (File.Exists(caminho))
            {
                File.Delete(caminho);
            }
            BotaoBaixarHabilitado();
            BotaoCancelarDesabilitado();
            Limpar();
        }

        private void labelFormato_Click(object sender, EventArgs e)
        {

        }

        private void chkBoxVideo_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxVideo.Checked == true)
            {
                chkBoxAudio.Enabled = false;
                cmbFormatos.DataSource = FormatosVideo();
            }
            else
            {
                chkBoxAudio.Enabled = true;
                cmbFormatos.DataSource = null;
            }
        }

        private void chkBoxAudio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAudio.Checked == true)
            {
                chkBoxVideo.Enabled = false;
                cmbFormatos.DataSource = FormatosAudio();
            }
            else
            {
                chkBoxVideo.Enabled = true;
                cmbFormatos.DataSource = null;
            }
        }
    }
}
