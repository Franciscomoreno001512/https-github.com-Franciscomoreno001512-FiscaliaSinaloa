using System;
using Spartane.Core.Domain.Catalogo_Numero_de_Preguntas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Catalogo_Numero_de_Preguntas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICatalogo_Numero_de_PreguntasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_PreguntasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Catalogo_Numero_de_Preguntas.Catalogo_Numero_de_Preguntas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
