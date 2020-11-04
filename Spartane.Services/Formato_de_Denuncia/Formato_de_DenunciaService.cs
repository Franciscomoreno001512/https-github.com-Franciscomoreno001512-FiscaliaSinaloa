using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Formato_de_Denuncia;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Formato_de_Denuncia
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Formato_de_DenunciaService : IFormato_de_DenunciaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> _Formato_de_DenunciaRepository;
        #endregion

        #region Ctor
        public Formato_de_DenunciaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> Formato_de_DenunciaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Formato_de_DenunciaRepository = Formato_de_DenunciaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> SelAll(bool ConRelaciones)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public IList<Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> SelAllComplete(bool ConRelaciones)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_DenunciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Formato_de_DenunciaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Formato_de_DenunciaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Formato_de_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia entity, Spartane.Core.Domain.User.GlobalData Formato_de_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Formato_de_Denuncia.Formato_de_Denuncia entity, Spartane.Core.Domain.User.GlobalData Formato_de_DenunciaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

