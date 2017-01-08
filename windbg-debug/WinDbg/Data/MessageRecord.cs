﻿using System;
using windbg_debug.WinDbg.Messages;
using windbg_debug.WinDbg.Results;

namespace windbg_debug.WinDbg.Data
{
    public class MessageRecord
    {
        public MessageRecord(Message message, Action<MessageResult> resultSetter)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            if (resultSetter == null)
                throw new ArgumentNullException(nameof(resultSetter));

            Message = message;
            ResultSetter = resultSetter;
        }

        public Message Message { get; private set; }
        public Action<MessageResult> ResultSetter { get; private set; }
    }
}
