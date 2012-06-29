using System;
using DreamSeat;
using MindTouch.Tasking;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Snively
{
    public class Note : CouchDocument
    {
        private static readonly Dictionary<string, string> views = new Dictionary<string, string>() {
            {"all",
                @"function(doc) {
                    if(doc[""type""] === $MODEL_NAME) {
                        emit(doc[""_id""], doc);
                    }
                }"},
        };

        public string Title {get; set;}
        public string Description {get; set;}

        // Parent IDs is a tricky one. I'd like to have a list of references ot
        // other Note objects, but there are two problems with this: because
        // this app is multithreaded/Task-based, I cannot give the identity
        // guarantee (ie., there *will* be multiple instances kicking around,
        // because I can't let multiple pieces of code have the same copies),
        // and, likewise, I may not have fetched copies of those objects yet (I
        // *could* do a fancy thing where I have proxies that update, but meh)

        public List<string> ParentIDs {get; set;}

        public Note()
        {
        }

        public static void UpdateDesignDocuments(CouchDatabase db)
        {
            var view = new CouchDesignDocument("explosionview");
            foreach (var pair in views)
            {
                var processed = pair.Value.Replace("$MODEL_NAME", typeof(Note).Name);
                view.Views.Add(pair.Key, new CouchView(processed));
            }

            db.CreateDocument(view, new Result<CouchDesignDocument>()).WhenDone((designDocument) => {
                Console.Out.WriteLine("Successfully written design doc!");
            }, (designDocumentError) => {
                Console.Out.WriteLine("Hah, couldn't write design doc: " + designDocumentError.Message);
            });
        }
    }
}

