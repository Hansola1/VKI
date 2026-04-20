using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFromToUseControlTraining
{
    public partial class MyComponent1 : Component
    {
        public MyComponent1()
        {
            InitializeComponent();
        }

        public MyComponent1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public event EventHandler MyTick;

        protected virtual void OnMyTick(EventArgs e)
        {
            MyTick?.Invoke(this, e);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine(DateTime.Now.ToString());
            OnMyTick(EventArgs.Empty);
        }
    }
}
