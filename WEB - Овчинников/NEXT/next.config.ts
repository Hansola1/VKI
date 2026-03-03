import type { NextConfig } from 'next'; 

const nextConfig: NextConfig = {
  /* config options here */
  eslint: {
    ignoreDuringBuilds: true, //игнор
  },
  typescript: {
    ignoreBuildErrors: true,
  },
};

export default nextConfig;  