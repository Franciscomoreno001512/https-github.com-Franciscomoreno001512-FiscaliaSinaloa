using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Historico_JA;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Historico_JA
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Historico_JAService : IDetalle_Historico_JAService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> _Detalle_Historico_JARepository;
        #endregion

        #region Ctor
        public Detalle_Historico_JAService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> Detalle_Historico_JARepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Historico_JARepository = Detalle_Historico_JARepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JAPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Historico_JAPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Historico_JARepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Historico_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA entity, Spartane.Core.Domain.User.GlobalData Detalle_Historico_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Historico_JA.Detalle_Historico_JA entity, Spartane.Core.Domain.User.GlobalData Detalle_Historico_JAInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

