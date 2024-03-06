﻿using DiaryApp;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiaryDataBase
{
    //här ärvs user username och user id från Konto. 
    public class User: Konto
    {
        //public User(string userName, int userId) : base(userName,userId)
        //{
        //    this.userName = userName;
        //    this.Id = userId;
        //}
        public string userName {  get; set; }
        public int userId { get; set; }
        public int passwordId { get; set; }
        public int commentId { get; set; }
        public override bool IsvalidName(string name)
        {
            userName= name;
            //kollar om namnet innehåller någt annat än bokstäver då ska vi retunerar falsk annars så har vi true
            char[] chars = name.ToCharArray();
            foreach (char c in chars)
            {
                if (!char.IsLetter(c))
                {
                    
                    return false;
                }
            }
            if (string.IsNullOrEmpty(name))
            {
                 
                return false;
            }
            else if(name.Length >= 8 ) 
            {
                 
                return false;
            }
            return true;
        }
    }
}