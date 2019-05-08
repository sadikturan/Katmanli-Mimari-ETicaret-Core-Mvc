using System.Collections.Generic;
using System.Linq;

namespace MovieApp.Models
{
    public static class Repository
    {
        private static List<Movie> _movies = null;

        static Repository()
        {
            _movies = new List<Movie>()
            {
                new Movie()
                {
                    Id=1,
                    Name="Shazam",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ShortDescription="Shazam",
                    ImageUrl="1.jpg"
                },
                new Movie() {
                    Id=2,
                    Name="Amazing Grace",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ShortDescription="Amazing Grace",
                    ImageUrl="2.jpg"
                },
                new Movie() {
                    Id=3,
                    Name="High Life",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ShortDescription="High Life",
                    ImageUrl="3.jpg"
                },
                new Movie() {
                    Id=4,
                    Name="Billboard",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ShortDescription="Billboard",
                    ImageUrl="4.jpg"
                },
                new Movie() {
                    Id=5,
                    Name="Storm Boy",
                    Description="<p>A beautiful and contemporary retelling of Colin Thiele's classic Australian tale. 'Storm Boy' has grown up to be Michael Kingley, a successful retired businessman and grandfather.</p> <p>When Kingley starts to see images from his past that he can't explain, he is forced to remember his long-forgotten childhood, growing up on an isolated coastline with his father. He recounts to his grand-daughter the story of how, as a boy, he rescued and raised an extraordinary orphaned pelican, Mr Percival.</p><p> Their remarkable adventures and very special bond has a profound effect on all their lives. Based on the beloved book, Storm Boy is a timeless story of an unusual and unconditional friendship.</p>",
                    ShortDescription="Storm Boy",
                    ImageUrl="5.jpg"
                }
            };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity)
        {
            _movies.Add(entity);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(i => i.Id == id);
        }


    }
}