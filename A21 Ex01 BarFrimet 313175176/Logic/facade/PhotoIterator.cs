using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex02.Logic.facade
{
    public class PhotoIterator : IEnumerable<Photo>
    {
        private FacebookObjectCollection<Album> m_UserAlbums;

        public PhotoIterator(FacebookObjectCollection<Album> i_UserAlbums)
        {
            this.m_UserAlbums = i_UserAlbums;
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            foreach (Album album in this.m_UserAlbums)
            {
                foreach (Photo photo in album.Photos)
                {
                    yield return photo;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
