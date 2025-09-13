'use client';

import { QueryClientProvider, DehydratedState } from '@tanstack/react-query';
import { ReactQueryDevtools } from '@tanstack/react-query-devtools';
import { HydrationBoundary } from '@tanstack/react-query';

import queryClient from '@/api/reactQueryClient';


interface Props {
  state: DehydratedState,
  children: React.ReactNode;
}

const TanStackQuery = ({ state, children }: Props) => (
  <QueryClientProvider client={queryClient}>
    <HydrationBoundary state={state}>
      {children}
    </HydrationBoundary>
    <ReactQueryDevtools initialIsOpen={false} />
  </QueryClientProvider>
);


export default TanStackQuery;
