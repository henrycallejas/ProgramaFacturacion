﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_dae
{
    public partial class CCF_RPT : Form
    {
        public CCF_RPT(int numFactura)
        {
            InitializeComponent();
            rptCCF1.SetParameterValue("@numFactura", numFactura);
        }
    }
}
