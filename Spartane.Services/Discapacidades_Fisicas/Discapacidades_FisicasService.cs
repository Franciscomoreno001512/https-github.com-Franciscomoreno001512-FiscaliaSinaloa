using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Discapacidades_Fisicas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Discapacidades_FisicasService : IDiscapacidades_FisicasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> _Discapacidades_FisicasRepository;
        #endregion

        #region Ctor
        public Discapacidades_FisicasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> Discapacidades_FisicasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Discapacidades_FisicasRepository = Discapacidades_FisicasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(bool ConRelaciones)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public IList<Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAllComplete(bool ConRelaciones)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_FisicasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Discapacidades_FisicasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Discapacidades_FisicasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData Discapacidades_FisicasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

