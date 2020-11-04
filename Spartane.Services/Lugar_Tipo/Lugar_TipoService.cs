using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Lugar_Tipo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Lugar_Tipo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Lugar_TipoService : ILugar_TipoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> _Lugar_TipoRepository;
        #endregion

        #region Ctor
        public Lugar_TipoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> Lugar_TipoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Lugar_TipoRepository = Lugar_TipoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(bool ConRelaciones)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public IList<Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAllComplete(bool ConRelaciones)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_Tipo.Lugar_TipoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Lugar_TipoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Lugar_TipoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Lugar_TipoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo entity, Spartane.Core.Domain.User.GlobalData Lugar_TipoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Lugar_Tipo.Lugar_Tipo entity, Spartane.Core.Domain.User.GlobalData Lugar_TipoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

