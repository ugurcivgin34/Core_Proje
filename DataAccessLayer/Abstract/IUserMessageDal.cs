using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IUserMessageDal : IGenericDal<UserMessage>
    {
        //Ön yüz de user.username şeklinde kulandığımızda hata veriyordu.Bu şekilde include metodunu uygulayarak hatanın önüne geçtik
        public List<UserMessage> GetUserMessagesWithUser();
    }
}
