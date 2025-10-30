'use client';

import { hydrate, QueryClientProvider, type DehydratedState } from '@tanstack/react-query';
import { ReactQueryDevtools } from '@tanstack/react-query-devtools';
import queryClient from '../api/reactQueryClient';

interface Props {
  state: DehydratedState;
  children: React.ReactNode;
}

const TanStackQuery = ({ state, children }: Props): React.ReactElement => {

  hydrate(queryClient, state)

  return (
  <QueryClientProvider client={queryClient}>
    {/* <HydrationBoundary
      state={state}
      queryClient={queryClient}
    > */}
      {children}
    {/* </HydrationBoundary> */}
    <ReactQueryDevtools initialIsOpen={false} />
  </QueryClientProvider>
  );
}

export default TanStackQuery;
