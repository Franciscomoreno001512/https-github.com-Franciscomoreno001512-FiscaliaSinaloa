using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Aseguramiento_de_Cargador_Cartuchos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Aseguramiento_de_Cargador_CartuchosService : IDetalle_Aseguramiento_de_Cargador_CartuchosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> _Detalle_Aseguramiento_de_Cargador_CartuchosRepository;
        #endregion

        #region Ctor
        public Detalle_Aseguramiento_de_Cargador_CartuchosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> Detalle_Aseguramiento_de_Cargador_CartuchosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository = Detalle_Aseguramiento_de_Cargador_CartuchosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Aseguramiento_de_Cargador_CartuchosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Aseguramiento_de_Cargador_CartuchosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Aseguramiento_de_Cargador_Cartuchos.Detalle_Aseguramiento_de_Cargador_Cartuchos entity, Spartane.Core.Domain.User.GlobalData Detalle_Aseguramiento_de_Cargador_CartuchosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

