using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnamSerkan.Models.Repository
{
    public class MessageRepository
    {
        public void SaveMessage(Message message)
        {
            
        }

        public static IEnumerable<Message> GetAllMessages(MessageDbContext messageDbContext)
        {
            List<Message> allMessages= messageDbContext.Messages.ToList();

            return allMessages;
        }
    }
}
