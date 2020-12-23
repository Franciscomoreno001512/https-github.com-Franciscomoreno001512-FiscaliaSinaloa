using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Institucion_Emisora;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Institucion_Emisora
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Institucion_EmisoraService : IInstitucion_EmisoraService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> _Institucion_EmisoraRepository;
        #endregion

        #region Ctor
        public Institucion_EmisoraService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> Institucion_EmisoraRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Institucion_EmisoraRepository = Institucion_EmisoraRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(bool ConRelaciones)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public IList<Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAllComplete(bool ConRelaciones)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Institucion_Emisora.Institucion_EmisoraPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Institucion_EmisoraPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Institucion_EmisoraRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Institucion_EmisoraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora entity, Spartane.Core.Domain.User.GlobalData Institucion_EmisoraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora entity, Spartane.Core.Domain.User.GlobalData Institucion_EmisoraInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

