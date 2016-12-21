﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class Article
    {
        private ICollection<Tag> tags;

        public Article()
        {
            this.tags = new HashSet<Tag>();
        }
		
		public Article(string authorId,string title,string content,int categoryId)
		{
			this.AuthorId=authorId;
			this.Title=title;
			this.Content=content;
			this.CategoryId=categoryId;
            this.tags = new HashSet<Tag>();
		}

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
		
		
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [ForeignKey("Author")]
        public string AuthorId { get; set; }

        public virtual ApplicationUser Author { get; set; }

        public bool IsAuthor(string name)
        {
            return this.Author.UserName.Equals(name);
        }
        public virtual ICollection<Tag>Tags
        {
            get { return this.tags;}
            set{this.tags=value;}
        }
        
    }
}