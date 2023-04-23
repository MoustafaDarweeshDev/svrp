using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entities
{
    public class WhiteListForms
    {
        public string Discord { get; set; }
        public string UserName { get; set; }
        public string Discriminator { get; set; }
        public string Avatar { get; set; }
        public int Status { get; set; }
        public int Type { get; set; }
        public int Tier { get; set; }
        public int region { get; set; }
        public string SteamId { get; set; }
        public string SteamLink { get; set; }
        public string SteamAvatar { get; set; }
        public string SteamUserName { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
        public string Q11 { get; set; }
        public string Q12 { get; set; }
        public string RejectReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
