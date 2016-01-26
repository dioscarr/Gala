using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace Gala_MVC_Project.Models
{
    public class PublicationModel : Basemodel
    {
        GalaDBEntities db = new GalaDBEntities();
        public Publication publication { get; set; }
        public List<publicationBooks> publicationbooks { get; set; }
        public publicationBooks SinglepublicationBooks { get; set; }
        public Gazette GazetteArticle { get; set; }
        public List<Gazette> GazetteArticles { get; set; }



        public PublicationModel()
        {
            publication = ManagePublication.GetAllPublication().FirstOrDefault();
            publicationbooks = ManagepublicationBooks.GetAllpublicationBooks().ToList();
            GazetteArticle = null;
            GazetteArticles = db.Gazette.ToList();
        }
        public void loadPublication(int id)
        {
            SinglepublicationBooks = db.publicationBooks.Where(c => c.Id == id).FirstOrDefault();
        }
        public bool update(PublicationModel model)
        {
            return ManagePublication.UpdatePublication(model.publication);
        }
        public bool Insert(PublicationModel model)
        {
            return ManagePublication.AddPublication(model.publication);
        }
        public bool Delete(int id)
        {
            return ManagepublicationBooks.DeletepublicationBooks(ManagepublicationBooks.GetById(id));
        }

    }
}