using Library.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateNewMember : Form
    {
        private MemberService memberService;

        public CreateNewMember(MemberService ms)
        {
            memberService = ms;
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string SocialNumber = addMemberSocialNum.Text;
            string Name = addMemberName.Text.Trim();
            Regex rx = new Regex(@"^([0-9]{6,8}-[0-9]{4}|[0-9]{6,8})$");
            if (rx.Match(SocialNumber).Success)
            {
                if(Name != "")
                {
                    Member newMember = new Member()
                    {
                        Name = Name,
                        SocialNumber = SocialNumber,
                        MemberSince = DateTime.Now
                    };
                    memberService.Add(newMember);
                }
                else
                {
                    MessageBox.Show("Please type your name.");
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect social number format. Format (yy)yymmdd-xxxx or (yy)yymmdd ");
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
