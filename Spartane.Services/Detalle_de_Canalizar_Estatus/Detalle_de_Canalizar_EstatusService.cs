using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_de_Canalizar_Estatus;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_de_Canalizar_Estatus
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_de_Canalizar_EstatusService : IDetalle_de_Canalizar_EstatusService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> _Detalle_de_Canalizar_EstatusRepository;
        #endregion

        #region Ctor
        public Detalle_de_Canalizar_EstatusService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> Detalle_de_Canalizar_EstatusRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_de_Canalizar_EstatusRepository = Detalle_de_Canalizar_EstatusRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> SelAll(bool ConRelaciones)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_EstatusPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_de_Canalizar_EstatusPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_de_Canalizar_EstatusRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_de_Canalizar_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Canalizar_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_de_Canalizar_Estatus.Detalle_de_Canalizar_Estatus entity, Spartane.Core.Domain.User.GlobalData Detalle_de_Canalizar_EstatusInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

