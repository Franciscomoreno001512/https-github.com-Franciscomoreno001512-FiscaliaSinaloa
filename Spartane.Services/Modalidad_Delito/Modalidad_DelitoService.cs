using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modalidad_Delito;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modalidad_Delito
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modalidad_DelitoService : IModalidad_DelitoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> _Modalidad_DelitoRepository;
        #endregion

        #region Ctor
        public Modalidad_DelitoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> Modalidad_DelitoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modalidad_DelitoRepository = Modalidad_DelitoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(bool ConRelaciones)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public IList<Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAllComplete(bool ConRelaciones)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modalidad_Delito.Modalidad_DelitoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modalidad_DelitoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modalidad_DelitoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Modalidad_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito entity, Spartane.Core.Domain.User.GlobalData Modalidad_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Modalidad_Delito.Modalidad_Delito entity, Spartane.Core.Domain.User.GlobalData Modalidad_DelitoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

