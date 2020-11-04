using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Elementos_Comision_Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Elementos_Comision_Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Elementos_Comision_DelitoService : IElementos_Comision_DelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> _Elementos_Comision_DelitoRepository;
        #endregion

        #region Ctor
        public Elementos_Comision_DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> Elementos_Comision_DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Elementos_Comision_DelitoRepository = Elementos_Comision_DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> SelAll(bool ConRelaciones)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Elementos_Comision_DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Elementos_Comision_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Elementos_Comision_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito entity, Spartane.Core.Domain.User.GlobalData Elementos_Comision_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Elementos_Comision_Delito.Elementos_Comision_Delito entity, Spartane.Core.Domain.User.GlobalData Elementos_Comision_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

