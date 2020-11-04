using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Medios_Alternativos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Medios_Alternativos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Medios_AlternativosService : IMedios_AlternativosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> _Medios_AlternativosRepository;
        #endregion

        #region Ctor
        public Medios_AlternativosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> Medios_AlternativosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Medios_AlternativosRepository = Medios_AlternativosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(bool ConRelaciones)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public IList<Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAllComplete(bool ConRelaciones)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Medios_Alternativos.Medios_AlternativosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Medios_AlternativosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Medios_AlternativosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Medios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos entity, Spartane.Core.Domain.User.GlobalData Medios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Medios_Alternativos.Medios_Alternativos entity, Spartane.Core.Domain.User.GlobalData Medios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

