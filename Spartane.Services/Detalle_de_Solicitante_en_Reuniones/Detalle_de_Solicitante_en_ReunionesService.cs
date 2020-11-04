using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Solicitante_en_Reuniones
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Solicitante_en_ReunionesService : IDetalle_de_Solicitante_en_ReunionesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> _Detalle_de_Solicitante_en_ReunionesRepository;
        #endregion

        #region Ctor
        public Detalle_de_Solicitante_en_ReunionesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> Detalle_de_Solicitante_en_ReunionesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Solicitante_en_ReunionesRepository = Detalle_de_Solicitante_en_ReunionesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_ReunionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Solicitante_en_ReunionesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Solicitante_en_ReunionesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitante_en_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitante_en_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Solicitante_en_Reuniones.Detalle_de_Solicitante_en_Reuniones entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Solicitante_en_ReunionesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

