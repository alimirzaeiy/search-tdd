using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace search_tdd
{
    public class DictionaryOfFilesAndTokens
    {
        private Dictionary<int, List<int>> TokenIndexByDocumentId { get; set; } = new Dictionary<int, List<int>>();

        public Dictionary<int, List<int>> GetDictionary()
        {
            return TokenIndexByDocumentId;
        }
        public List<int> GetTokenIndices(int documentId)
        {
            if (TokenIndexByDocumentId.ContainsKey(documentId)) return TokenIndexByDocumentId[documentId];
            else return null;
        }
        public void AddTokenIndices(int documentId,int index)
        {
            if (TokenIndexByDocumentId.ContainsKey(documentId)) TokenIndexByDocumentId[documentId].Add(index);
            else TokenIndexByDocumentId.Add(documentId, new List<int> { index });
        }
        public void AddTokenIndices(int documentId, List<int> indices)
        {
            if (TokenIndexByDocumentId.ContainsKey(documentId)) {
                for (int i = 0; i < indices.Count; i++)
                {
                    TokenIndexByDocumentId[documentId].Add(indices[i]);
                }
            } 
            else TokenIndexByDocumentId.Add(documentId, indices);
        }
        public void SetTokenIndices(int documentId , List<int> indices)
        {
            if (TokenIndexByDocumentId.ContainsKey(documentId)) TokenIndexByDocumentId[documentId] = indices;  
            else TokenIndexByDocumentId.Add(documentId, indices);
        }
    }
}
