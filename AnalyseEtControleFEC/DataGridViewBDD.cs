using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProCol
{
    class DataGridViewBDD : DataGridView
    {
        public int numGridView { get; set; }

        public DataGridViewBDD(int numGridView) : base()
        {
            this.numGridView = numGridView;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Location = new System.Drawing.Point(6, 6);
            this.RowTemplate.Height = 27;
            this.Size = new System.Drawing.Size(1345, 867);
            this.TabIndex = 2;
            this.VirtualMode = true;
        }
    }
}
