using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;
using Task_3.ViewModels;

namespace Task_3.ViewModels
{
    class ViewModel
    {
        Model model = null;
        MainWindow view = null;


        public ViewModel(MainWindow view)
        {
            this.model = new Model();
            this.view = view;
            this.view.myStart += new EventHandler(button_Start_Click);
            this.view.myStop += new EventHandler(button_Stop_Click);
            this.view.myReset += new EventHandler(button_Reset_Click);
        }
        private void button_Start_Click(object sender, EventArgs e)
        {
            view.Stopwatch.Text = model.StartTimer();

        }
        private void button_Stop_Click(object sender, EventArgs e)
        {
            model.Stop();
        }
        private void button_Reset_Click(object sender, EventArgs e)
        {
            model.Reset();
        }
    }
}
