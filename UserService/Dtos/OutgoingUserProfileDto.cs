﻿namespace UserService.Dtos
{
    public class OutgoingUserProfileDto
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string EmailId { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
    }
}
