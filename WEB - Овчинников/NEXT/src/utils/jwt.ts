// import jwt from 'jsonwebtoken';
// import crypto from 'node:crypto';

// type JwtPayload = Record<string, unknown>;

// const base64UrlEncode = (input: Buffer | string): string => {
//   const base64 = Buffer.isBuffer(input)
//     ? input.toString('base64')
//     : Buffer.from(input).toString('base64');

//   return base64.replace(/=/g, '').replace(/\+/g, '-').replace(/\//g, '_');
// };

// const getJwtSecret = (): string => {
//   // const secret = process.env.JWT_SECRET;
//   const secret = 'secret';

//   if (!secret) {
//     throw new Error('JWT_SECRET is not set');
//   }

//   return secret;
// };

// export const signJwt = (payload: JwtPayload, expiresInSeconds: number = 60 * 60): string => {
//   const header = {
//     alg: 'HS256',
//     typ: 'JWT',
//   };

//   const timestamp = Math.floor(Date.now() / 1000);

//   const finalPayload = {
//     ...payload,
//     iat: timestamp,
//     exp: timestamp + expiresInSeconds,
//   };

//   const encodedHeader = base64UrlEncode(JSON.stringify(header));
//   const encodedPayload = base64UrlEncode(JSON.stringify(finalPayload));

//   const data = `${encodedHeader}.${encodedPayload}`;

//   const signature = crypto
//     .createHmac('sha256', getJwtSecret())
//     .update(data)
//     .digest('base64')
//     .replace(/=/g, '')
//     .replace(/\+/g, '-')
//     .replace(/\//g, '_');

//   return `${data}.${signature}`;
// };

// // Валидация access token
// export const verifyAccessToken = (token?: string): string | JwtPayload | null => {
//   if (!token) {
//     return null;
//   }
//   try {
//     return jwt.verify(token, getJwtSecret());
//   }
//   catch (error) {
//     console.error(error);
//     return null;
//   }
// };