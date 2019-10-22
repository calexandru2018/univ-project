using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Services;

namespace Library
{
    public partial class MemberList : Form
    {
        private MemberService memberService;

        public MemberList(MemberService ms)
        {
            memberService = ms;
            memberService.Updated += MemberService_Updated;
            InitializeComponent();
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            //memberService.add;
        }

        private void MemberList_Load(object sender, EventArgs e)
        {

        }
    }
}
