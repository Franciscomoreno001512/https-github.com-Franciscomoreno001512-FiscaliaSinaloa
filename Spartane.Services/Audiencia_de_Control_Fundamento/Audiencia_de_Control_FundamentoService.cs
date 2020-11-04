using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_de_Control_Fundamento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_de_Control_Fundamento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_de_Control_FundamentoService : IAudiencia_de_Control_FundamentoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> _Audiencia_de_Control_FundamentoRepository;
        #endregion

        #region Ctor
        public Audiencia_de_Control_FundamentoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> Audiencia_de_Control_FundamentoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_de_Control_FundamentoRepository = Audiencia_de_Control_FundamentoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_FundamentoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_de_Control_FundamentoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_de_Control_FundamentoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_FundamentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_FundamentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_de_Control_Fundamento.Audiencia_de_Control_Fundamento entity, Spartane.Core.Domain.User.GlobalData Audiencia_de_Control_FundamentoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

