## DupNotHandlerExec (DuplicatedNotificationHandlerExecution)

This repo is a small reproduction of a bug I stumbled upon.
It has generic `MediatR` notification handlers that get triggered twice when one of the generics has no specialised handler registered.

There is a Github Issue from another user how has the same problem: https://github.com/jbogard/MediatR/issues/884
It turns out that this is not a `MediatR` issue and instead a bug in the Microsoft `DI` container: https://github.com/dotnet/runtime/issues/87017#issuecomment-1585432547