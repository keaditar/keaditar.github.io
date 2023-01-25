using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeklandBankSystem.Infrastructure
{
    /*public interface IBotServices
    {
        BotUser GetBotUser(long vkId);
        void CreateUserBot(BotUser user);
        void SaveUser(BotUser user);

        List<Item> GetUserItems(BotUser user);
        Item GetItem(int id);
        List<Item> GetUserEq(BotUser user);
        UserItem GetUserItem(int ItemId);

        void CreateUserItem(UserItem userItem);
    }

    public class BotServices : IBotServices
    {
        public BotServices(BankContext _bdb, IHttpContextAccessor hcontext, IBankServices banksrv)
        {
            bdb = _bdb;
            _httpContext = hcontext;
            _bankServices = banksrv;
        }

        private BankContext bdb { get; set; }
        private IBankServices _bankServices { get; set; }
        private IHttpContextAccessor _httpContext { get; set; }

        public Item GetItem(int id)
        {
            return bdb.Items.Where(m => m.Id == id).FirstOrDefault();
        }

        public UserItem GetUserItem(int ItemId)
        {
            return bdb.UserItems.Where(m => m.ItemId == ItemId).FirstOrDefault();
        }

        public void CreateUserItem(UserItem userItem)
        {
            bdb.UserItems.Add(userItem);
            bdb.SaveChanges();
        }

        public void SaveUser(BotUser user)
        {
            bdb.BotUsers.Update(user);
            bdb.SaveChanges();
        }

        public List<Item> GetUserEq(BotUser user)
        {
            var list = new List<Item>();

            var head = GetItem(user.Head);
            if(head != null)
                list.Append(head);

            var body = GetItem(user.Body);
            if (body != null)
                list.Append(body);

            var legs = GetItem(user.Legs);
            if (legs != null)
                list.Append(legs);

            var weapon = GetItem(user.Weapon);
            if (weapon != null)
                list.Append(weapon);

            var acc = GetItem(user.Accesuar);
            if (acc != null)
                list.Append(acc);

            return list;
        }

        public List<Item> GetUserItems(BotUser user)
        {
            var items_list = bdb.UserItems.Where(m => m.UserId == user.Id);

            var list_return = new List<Item>();

            foreach(var it in items_list)
            {
                var item = GetItem(it.ItemId);
                list_return.Append(item);
            }

            return list_return;
        }

        public void CreateUserBot(BotUser user)
        {
            bdb.BotUsers.Add(user);
            bdb.SaveChanges();
        }

        public BotUser GetBotUser(long vkId)
        {
            return bdb.BotUsers.Where(m => m.VkId == vkId).FirstOrDefault();
        }
    }*/
}
