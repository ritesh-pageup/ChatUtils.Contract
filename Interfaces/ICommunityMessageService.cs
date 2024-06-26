﻿using ChatUtils.Contract.Dtos.CommunityMessageDto;
using ChatUtils.Contract.Dtos.PaginationDto;
using ChatUtils.Contract.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChatUtils.Contract.Interfaces
{
    public interface ICommunityMessageService
    {
        /// <summary>
        /// This method is used for sending a message for that perticular reciever id.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="claim"></param>
        /// <param name="RecieverId"></param>
        /// <returns>ResponseMsg</returns>
        public Task<ResponseWithObjectMessage<MessageBoxDto>> SendMessage(MessageDto messageDto, long SenderId, long? RecieverId, bool isBlockedMe);

        /// <summary>
        /// This method is used for fetch user Conversation between two Employee
        /// </summary>
        /// <param name="claim"></param>
        /// <param name="RecieverId"></param>
        /// <returns>ResponseWIthEterableMessage - Return a Response with List of MessageBoxDto object</returns>
        public Task<ResponseWithObjectMessage<MessageBoxTokenDto>> DisplayMessage(long SenderId, long? RecieverId, MessagePageDto pageDto, bool IsGroup, bool isBlockedUser);

        /// <summary>
        /// This method is used for Delete the message by it's Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ResponseMsg</returns>
        public Task<ResponseMsg> DeleteMessage(MultipleOperationDto dto, long SenderId);

        /// <summary>
        /// This method is used for getting all Chats between Employee with Last message.
        /// </summary>
        /// <param name="claim"></param>
        /// <returns>ResponseWIthEterableMessage - Return a Response with List of ChatBoxDto object</returns>
        public Task<ResponseWIthEterableMessage<ChatBoxDto>> GetChatBox(long SenderId);
        public Task<ResponseMsg> DeleteChatBox(long ReceiverID, long SenderId, bool IsGroup);
        public Task<ResponseMsg> CreateGroup(ChatGroupDto chatGroupDto, long UserId);
        public Task<ResponseMsg> UpdateGroup(ChatGroupDto chatGroupDto, long UserId);
        public Task<ChatGroupResponse> GetChatGroup(long Id, long SenderId);
        public Task<ResponseMsg> MessageReached(long UserId);
        public Task<ResponseWithDataAndCount<ChatGroupDto>> GetChatGroups(long SenderId);
    }
}
