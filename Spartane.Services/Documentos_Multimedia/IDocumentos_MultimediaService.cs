using System;
using Spartane.Core.Domain.Documentos_Multimedia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Documentos_Multimedia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDocumentos_MultimediaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Documentos_Multimedia.Documentos_MultimediaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Documentos_Multimedia.Documentos_Multimedia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
