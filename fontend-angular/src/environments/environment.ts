import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Manag',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44367',
    redirectUri: baseUrl,
    clientId: 'Manag_App',
    responseType: 'code',
    scope: 'offline_access Manag',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44367',
      rootNamespace: 'ABStr.Budget.Manag',
    },
  },
} as Environment;
