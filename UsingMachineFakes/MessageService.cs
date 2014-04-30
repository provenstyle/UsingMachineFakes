namespace ProvenStyle.UsingMachineFakes
{
    public class MessageService
    {
        private IMessageService _messageService;

        public MessageService(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public string GetMessage()
        {
            return _messageService.Message;
        }
    }
}