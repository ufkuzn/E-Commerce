using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace EC.IdentityServer;

public static class Config
{
    public static IEnumerable<ApiResource> ApiResources => new ApiResource[]  //Registrationı HostingExtension.cs'te yapıldı.
        {
            new ApiResource("ResourceCatalog") //ResourceCatalog adında bir api kaynağı oluşturuldu. Bu kaynağa erişimi olan kullanıcılar aşağıdaki yetkilere sahip olabilirler.
            {
                Scopes = {"CatalogFullPermission", "CatalogReadPermission"}
            },

            new ApiResource("ResourceDiscount")
            {
                Scopes = {"DiscountFullPermission"}
            },

            new ApiResource("ResourceOrder")
            {
                Scopes = {"OrderFullPermission"}
            },

            new ApiResource("ResourceCargo")
            {
                Scopes = {"CargoFullPermission"}
            },

            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

    public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
    {
        //Kullanıcı authentication işlemlerinde aşağıdaki bilgiler alınabilir.
        new IdentityResources.OpenId(),
        new IdentityResources.Email(),
        new IdentityResources.Profile()
    };

    public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
    {
        //API kaynağına erişim yetkileri tanımlanır.
        new ApiScope("CatalogFullPermission", "Full authority for catalog operations"),
        new ApiScope("CatalogReadPermission", "Read authority for catalog operations"),
        new ApiScope("DiscountFullPermission", "Full authority for discount operations"),
        new ApiScope("OrderFullPermission", "Full authority for order operations"),
        new ApiScope("CargoFullPermission", "Full authority for cargo operations"),
        new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
    };

    //Kullanıcı tipi işlemleri
    public static IEnumerable<Client> Clients => new Client[]
    {
        //Ziyaretçinin sahip olacağı izinler.
        new Client
        {
            ClientId = "ECommerceVisitorId",
            ClientName = "ECommerce Visitor User",
            AllowedGrantTypes = GrantTypes.ClientCredentials, //Yetkilendirme akışı. Kullanıcı adı ve şifre gerektirmeyen, sistem-tabanlı (machine-to-machine) kimlik doğrulaması kullanıyor.
            ClientSecrets = {new Secret("ecommercesecretvisitor".Sha256())}, //istemcinin secret keyi
            AllowedScopes = { "DiscountFullPermission" } //Sahip olduğu yetkiler.
        },

        //Yönetici
        new Client
        {
            ClientId = "ECommerceManagerId",
            ClientName = "ECommerce Manager User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("ecommercesecretmanager".Sha256())},
            AllowedScopes = {"CatalogFullPermission", "CatalogReadPermission"}
        },

        //Admin
        new Client
        {
            ClientId = "ECommerceAdminId",
            ClientName = "ECommerce Admin User",
            AllowedGrantTypes = GrantTypes.ClientCredentials,
            ClientSecrets = {new Secret("ecommercesecretadmin".Sha256())},
            AllowedScopes = {"CatalogFullPermission", "CatalogReadPermission", "DiscountFullPermission", "OrderFullPermission", "CargoFullPermission", IdentityServerConstants.LocalApi.ScopeName, IdentityServerConstants.StandardScopes.Email,IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Profile},
            AccessTokenLifetime = 600 //sn
        }
    };
}
