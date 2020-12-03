using System;
using Spartane.Core.Domain.Tipo_de_Droga;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Droga
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_DrogaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_DrogaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Droga.Tipo_de_Droga> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
