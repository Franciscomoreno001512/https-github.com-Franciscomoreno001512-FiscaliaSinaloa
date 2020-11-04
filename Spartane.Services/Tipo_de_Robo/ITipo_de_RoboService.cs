using System;
using Spartane.Core.Domain.Tipo_de_Robo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Robo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_RoboService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_RoboPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Robo.Tipo_de_Robo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
