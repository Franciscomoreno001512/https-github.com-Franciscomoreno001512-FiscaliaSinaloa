using System;
using Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Aparato_Electronicos_y_Multimedia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAparato_Electronicos_y_MultimediaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_MultimediaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Aparato_Electronicos_y_Multimedia.Aparato_Electronicos_y_Multimedia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
