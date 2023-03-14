﻿using MediatR;
using Students.Application.Common.CommitTag;

namespace Students.Application.Lessons.Commands.CreateLesson;

public class CreateLessonCommand : IRequest<int>, ICommittable
{
    public string LessonTitle { get; set; }
    public int TransactionCount { get; set; }
}