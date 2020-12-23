using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Direccion_Exacta;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Direccion_Exacta
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Direccion_ExactaService : IDireccion_ExactaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> _Direccion_ExactaRepository;
        #endregion

        #region Ctor
        public Direccion_ExactaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> Direccion_ExactaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Direccion_ExactaRepository = Direccion_ExactaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(bool ConRelaciones)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public IList<Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAllComplete(bool ConRelaciones)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Direccion_Exacta.Direccion_ExactaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Direccion_ExactaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Direccion_ExactaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Direccion_ExactaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta entity, Spartane.Core.Domain.User.GlobalData Direccion_ExactaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta entity, Spartane.Core.Domain.User.GlobalData Direccion_ExactaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

