using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormPleaseWait
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      using (FormWait wait = new FormWait())
      {
        wait.Show();
        Application.DoEvents();
        // add your code here
        Thread.Sleep(5000);
        wait.Close();
      }
    }
  }
}
