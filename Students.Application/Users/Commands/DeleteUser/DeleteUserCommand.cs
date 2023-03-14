﻿using MediatR;
using Students.Application.Common.CommitTag;

namespace Students.Application.Users.Commands.DeleteUser;

public class DeleteUserCommand : IRequest<int>, ICommittable
{
    public int UserId { get; set; }
    public int TransactionCount { get; set; }
}