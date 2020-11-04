using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Especialista_de_Justicia_Alternativa;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Especialista_de_Justicia_Alternativa
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Especialista_de_Justicia_AlternativaService : IEspecialista_de_Justicia_AlternativaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> _Especialista_de_Justicia_AlternativaRepository;
        #endregion

        #region Ctor
        public Especialista_de_Justicia_AlternativaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> Especialista_de_Justicia_AlternativaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Especialista_de_Justicia_AlternativaRepository = Especialista_de_Justicia_AlternativaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(bool ConRelaciones)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public IList<Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAllComplete(bool ConRelaciones)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_AlternativaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Especialista_de_Justicia_AlternativaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Especialista_de_Justicia_AlternativaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Spartane.Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Especialista_de_Justicia_Alternativa.Especialista_de_Justicia_Alternativa entity, Spartane.Core.Domain.User.GlobalData Especialista_de_Justicia_AlternativaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

