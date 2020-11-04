using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Servicios_Alternativos;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Servicios_Alternativos
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Servicios_AlternativosService : IServicios_AlternativosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> _Servicios_AlternativosRepository;
        #endregion

        #region Ctor
        public Servicios_AlternativosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> Servicios_AlternativosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Servicios_AlternativosRepository = Servicios_AlternativosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(bool ConRelaciones)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public IList<Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAllComplete(bool ConRelaciones)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicios_Alternativos.Servicios_AlternativosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Servicios_AlternativosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Servicios_AlternativosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Servicios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos entity, Spartane.Core.Domain.User.GlobalData Servicios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Servicios_Alternativos.Servicios_Alternativos entity, Spartane.Core.Domain.User.GlobalData Servicios_AlternativosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

