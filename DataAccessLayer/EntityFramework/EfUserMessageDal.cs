﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
    {
        //Ön yüz de user.username şeklinde kulandığımızda hata veriyordu.Bu şekilde include metodunu uygulayarak hatanın önüne geçtik.İş katmanını da ona göre düzenledik.
        public List<UserMessage> GetUserMessagesWithUser()
        {
            using (var c=new Context())
            {
                return c.UserMessages.Include(x => x.User).ToList();
            }
        }
    }
}
