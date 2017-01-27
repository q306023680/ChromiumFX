// Copyright (c) 2014-2017 Wolfgang Borgsmüller
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license. See the License.txt file for details.

// Generated file. Do not edit.


using System;

namespace Chromium.Remote {
    internal enum RemoteCallId : ushort {
        CfrMarshalAllocHGlobalRemoteCall,
        CfrMarshalCopyToManagedIntPtrArrayRemoteCall,
        CfrMarshalCopyToManagedRemoteCall,
        CfrMarshalCopyToNativeRemoteCall,
        CfrMarshalFreeHGlobalRemoteCall,
        CfrMarshalPtrToStringUniRemoteCall,
        CfxApiReleaseRemoteCall,
        CfxAppCtorWithGCHandleRemoteCall,
        CfxAppGetRenderProcessHandlerRemoteEventCall,
        CfxAppGetResourceBundleHandlerRemoteEventCall,
        CfxAppOnBeforeCommandLineProcessingRemoteEventCall,
        CfxAppOnRegisterCustomSchemesRemoteEventCall,
        CfxAppSetCallbackRemoteCall,
        CfxBinaryValueCopyRemoteCall,
        CfxBinaryValueCreateFromArrayRemoteCall,
        CfxBinaryValueCreateRemoteCall,
        CfxBinaryValueGetDataRemoteCall,
        CfxBinaryValueGetSizeRemoteCall,
        CfxBinaryValueIsEqualRemoteCall,
        CfxBinaryValueIsOwnedRemoteCall,
        CfxBinaryValueIsSameRemoteCall,
        CfxBinaryValueIsValidRemoteCall,
        CfxBrowserCanGoBackRemoteCall,
        CfxBrowserCanGoForwardRemoteCall,
        CfxBrowserGetFocusedFrameRemoteCall,
        CfxBrowserGetFrameByIdentifierRemoteCall,
        CfxBrowserGetFrameCountRemoteCall,
        CfxBrowserGetFrameIdentifiersRemoteCall,
        CfxBrowserGetFrameNamesRemoteCall,
        CfxBrowserGetFrameRemoteCall,
        CfxBrowserGetIdentifierRemoteCall,
        CfxBrowserGetMainFrameRemoteCall,
        CfxBrowserGoBackRemoteCall,
        CfxBrowserGoForwardRemoteCall,
        CfxBrowserHasDocumentRemoteCall,
        CfxBrowserIsLoadingRemoteCall,
        CfxBrowserIsPopupRemoteCall,
        CfxBrowserIsSameRemoteCall,
        CfxBrowserReloadIgnoreCacheRemoteCall,
        CfxBrowserReloadRemoteCall,
        CfxBrowserSendProcessMessageRemoteCall,
        CfxBrowserStopLoadRemoteCall,
        CfxCommandLineAppendArgumentRemoteCall,
        CfxCommandLineAppendSwitchRemoteCall,
        CfxCommandLineAppendSwitchWithValueRemoteCall,
        CfxCommandLineCopyRemoteCall,
        CfxCommandLineCreateRemoteCall,
        CfxCommandLineGetArgumentsRemoteCall,
        CfxCommandLineGetArgvRemoteCall,
        CfxCommandLineGetCommandLineStringRemoteCall,
        CfxCommandLineGetGlobalRemoteCall,
        CfxCommandLineGetProgramRemoteCall,
        CfxCommandLineGetSwitchesRemoteCall,
        CfxCommandLineGetSwitchValueRemoteCall,
        CfxCommandLineHasArgumentsRemoteCall,
        CfxCommandLineHasSwitchesRemoteCall,
        CfxCommandLineHasSwitchRemoteCall,
        CfxCommandLineInitFromArgvRemoteCall,
        CfxCommandLineInitFromStringRemoteCall,
        CfxCommandLineIsReadOnlyRemoteCall,
        CfxCommandLineIsValidRemoteCall,
        CfxCommandLinePrependWrapperRemoteCall,
        CfxCommandLineResetRemoteCall,
        CfxCommandLineSetProgramRemoteCall,
        CfxDictionaryValueClearRemoteCall,
        CfxDictionaryValueCopyRemoteCall,
        CfxDictionaryValueCreateRemoteCall,
        CfxDictionaryValueGetBinaryRemoteCall,
        CfxDictionaryValueGetBoolRemoteCall,
        CfxDictionaryValueGetDictionaryRemoteCall,
        CfxDictionaryValueGetDoubleRemoteCall,
        CfxDictionaryValueGetIntRemoteCall,
        CfxDictionaryValueGetKeysRemoteCall,
        CfxDictionaryValueGetListRemoteCall,
        CfxDictionaryValueGetSizeRemoteCall,
        CfxDictionaryValueGetStringRemoteCall,
        CfxDictionaryValueGetTypeRemoteCall,
        CfxDictionaryValueGetValueRemoteCall,
        CfxDictionaryValueHasKeyRemoteCall,
        CfxDictionaryValueIsEqualRemoteCall,
        CfxDictionaryValueIsOwnedRemoteCall,
        CfxDictionaryValueIsReadOnlyRemoteCall,
        CfxDictionaryValueIsSameRemoteCall,
        CfxDictionaryValueIsValidRemoteCall,
        CfxDictionaryValueRemoveRemoteCall,
        CfxDictionaryValueSetBinaryRemoteCall,
        CfxDictionaryValueSetBoolRemoteCall,
        CfxDictionaryValueSetDictionaryRemoteCall,
        CfxDictionaryValueSetDoubleRemoteCall,
        CfxDictionaryValueSetIntRemoteCall,
        CfxDictionaryValueSetListRemoteCall,
        CfxDictionaryValueSetNullRemoteCall,
        CfxDictionaryValueSetStringRemoteCall,
        CfxDictionaryValueSetValueRemoteCall,
        CfxDomDocumentGetBaseUrlRemoteCall,
        CfxDomDocumentGetBodyRemoteCall,
        CfxDomDocumentGetCompleteUrlRemoteCall,
        CfxDomDocumentGetDocumentRemoteCall,
        CfxDomDocumentGetElementByIdRemoteCall,
        CfxDomDocumentGetFocusedNodeRemoteCall,
        CfxDomDocumentGetHeadRemoteCall,
        CfxDomDocumentGetSelectionAsMarkupRemoteCall,
        CfxDomDocumentGetSelectionAsTextRemoteCall,
        CfxDomDocumentGetSelectionEndOffsetRemoteCall,
        CfxDomDocumentGetSelectionStartOffsetRemoteCall,
        CfxDomDocumentGetTitleRemoteCall,
        CfxDomDocumentGetTypeRemoteCall,
        CfxDomDocumentHasSelectionRemoteCall,
        CfxDomNodeGetAsMarkupRemoteCall,
        CfxDomNodeGetDocumentRemoteCall,
        CfxDomNodeGetElementAttributeRemoteCall,
        CfxDomNodeGetElementAttributesRemoteCall,
        CfxDomNodeGetElementBoundsRemoteCall,
        CfxDomNodeGetElementInnerTextRemoteCall,
        CfxDomNodeGetElementTagNameRemoteCall,
        CfxDomNodeGetFirstChildRemoteCall,
        CfxDomNodeGetFormControlElementTypeRemoteCall,
        CfxDomNodeGetLastChildRemoteCall,
        CfxDomNodeGetNameRemoteCall,
        CfxDomNodeGetNextSiblingRemoteCall,
        CfxDomNodeGetParentRemoteCall,
        CfxDomNodeGetPreviousSiblingRemoteCall,
        CfxDomNodeGetTypeRemoteCall,
        CfxDomNodeGetValueRemoteCall,
        CfxDomNodeHasChildrenRemoteCall,
        CfxDomNodeHasElementAttributeRemoteCall,
        CfxDomNodeHasElementAttributesRemoteCall,
        CfxDomNodeIsEditableRemoteCall,
        CfxDomNodeIsElementRemoteCall,
        CfxDomNodeIsFormControlElementRemoteCall,
        CfxDomNodeIsSameRemoteCall,
        CfxDomNodeIsTextRemoteCall,
        CfxDomNodeSetElementAttributeRemoteCall,
        CfxDomNodeSetValueRemoteCall,
        CfxDomVisitorCtorWithGCHandleRemoteCall,
        CfxDomVisitorSetCallbackRemoteCall,
        CfxDomVisitorVisitRemoteEventCall,
        CfxFrameCopyRemoteCall,
        CfxFrameCutRemoteCall,
        CfxFrameDelRemoteCall,
        CfxFrameExecuteJavaScriptRemoteCall,
        CfxFrameGetBrowserRemoteCall,
        CfxFrameGetIdentifierRemoteCall,
        CfxFrameGetNameRemoteCall,
        CfxFrameGetParentRemoteCall,
        CfxFrameGetSourceRemoteCall,
        CfxFrameGetTextRemoteCall,
        CfxFrameGetUrlRemoteCall,
        CfxFrameGetV8ContextRemoteCall,
        CfxFrameIsFocusedRemoteCall,
        CfxFrameIsMainRemoteCall,
        CfxFrameIsValidRemoteCall,
        CfxFrameLoadRequestRemoteCall,
        CfxFrameLoadStringRemoteCall,
        CfxFrameLoadUrlRemoteCall,
        CfxFramePasteRemoteCall,
        CfxFrameRedoRemoteCall,
        CfxFrameSelectAllRemoteCall,
        CfxFrameUndoRemoteCall,
        CfxFrameVisitDomRemoteCall,
        CfxListValueClearRemoteCall,
        CfxListValueCopyRemoteCall,
        CfxListValueCreateRemoteCall,
        CfxListValueGetBinaryRemoteCall,
        CfxListValueGetBoolRemoteCall,
        CfxListValueGetDictionaryRemoteCall,
        CfxListValueGetDoubleRemoteCall,
        CfxListValueGetIntRemoteCall,
        CfxListValueGetListRemoteCall,
        CfxListValueGetSizeRemoteCall,
        CfxListValueGetStringRemoteCall,
        CfxListValueGetTypeRemoteCall,
        CfxListValueGetValueRemoteCall,
        CfxListValueIsEqualRemoteCall,
        CfxListValueIsOwnedRemoteCall,
        CfxListValueIsReadOnlyRemoteCall,
        CfxListValueIsSameRemoteCall,
        CfxListValueIsValidRemoteCall,
        CfxListValueRemoveRemoteCall,
        CfxListValueSetBinaryRemoteCall,
        CfxListValueSetBoolRemoteCall,
        CfxListValueSetDictionaryRemoteCall,
        CfxListValueSetDoubleRemoteCall,
        CfxListValueSetIntRemoteCall,
        CfxListValueSetListRemoteCall,
        CfxListValueSetNullRemoteCall,
        CfxListValueSetSizeRemoteCall,
        CfxListValueSetStringRemoteCall,
        CfxListValueSetValueRemoteCall,
        CfxLoadHandlerCtorWithGCHandleRemoteCall,
        CfxLoadHandlerOnLoadEndRemoteEventCall,
        CfxLoadHandlerOnLoadErrorRemoteEventCall,
        CfxLoadHandlerOnLoadingStateChangeRemoteEventCall,
        CfxLoadHandlerOnLoadStartRemoteEventCall,
        CfxLoadHandlerSetCallbackRemoteCall,
        CfxPostDataAddElementRemoteCall,
        CfxPostDataCreateRemoteCall,
        CfxPostDataElementCreateRemoteCall,
        CfxPostDataElementGetBytesCountRemoteCall,
        CfxPostDataElementGetBytesRemoteCall,
        CfxPostDataElementGetFileRemoteCall,
        CfxPostDataElementGetTypeRemoteCall,
        CfxPostDataElementIsReadOnlyRemoteCall,
        CfxPostDataElementSetToBytesRemoteCall,
        CfxPostDataElementSetToEmptyRemoteCall,
        CfxPostDataElementSetToFileRemoteCall,
        CfxPostDataGetElementCountRemoteCall,
        CfxPostDataGetElementsRemoteCall,
        CfxPostDataHasExcludedElementsRemoteCall,
        CfxPostDataIsReadOnlyRemoteCall,
        CfxPostDataRemoveElementRemoteCall,
        CfxPostDataRemoveElementsRemoteCall,
        CfxProcessMessageCopyRemoteCall,
        CfxProcessMessageCreateRemoteCall,
        CfxProcessMessageGetArgumentListRemoteCall,
        CfxProcessMessageGetNameRemoteCall,
        CfxProcessMessageIsReadOnlyRemoteCall,
        CfxProcessMessageIsValidRemoteCall,
        CfxReadHandlerCtorWithGCHandleRemoteCall,
        CfxReadHandlerEofRemoteEventCall,
        CfxReadHandlerMayBlockRemoteEventCall,
        CfxReadHandlerReadRemoteEventCall,
        CfxReadHandlerSeekRemoteEventCall,
        CfxReadHandlerSetCallbackRemoteCall,
        CfxReadHandlerTellRemoteEventCall,
        CfxRectCtorRemoteCall,
        CfxRectDtorRemoteCall,
        CfxRectGetHeightRemoteCall,
        CfxRectGetWidthRemoteCall,
        CfxRectGetXRemoteCall,
        CfxRectGetYRemoteCall,
        CfxRectSetHeightRemoteCall,
        CfxRectSetWidthRemoteCall,
        CfxRectSetXRemoteCall,
        CfxRectSetYRemoteCall,
        CfxRenderProcessHandlerCtorWithGCHandleRemoteCall,
        CfxRenderProcessHandlerGetLoadHandlerRemoteEventCall,
        CfxRenderProcessHandlerOnBeforeNavigationRemoteEventCall,
        CfxRenderProcessHandlerOnBrowserCreatedRemoteEventCall,
        CfxRenderProcessHandlerOnBrowserDestroyedRemoteEventCall,
        CfxRenderProcessHandlerOnContextCreatedRemoteEventCall,
        CfxRenderProcessHandlerOnContextReleasedRemoteEventCall,
        CfxRenderProcessHandlerOnFocusedNodeChangedRemoteEventCall,
        CfxRenderProcessHandlerOnProcessMessageReceivedRemoteEventCall,
        CfxRenderProcessHandlerOnRenderThreadCreatedRemoteEventCall,
        CfxRenderProcessHandlerOnUncaughtExceptionRemoteEventCall,
        CfxRenderProcessHandlerOnWebKitInitializedRemoteEventCall,
        CfxRenderProcessHandlerSetCallbackRemoteCall,
        CfxRequestCreateRemoteCall,
        CfxRequestGetFirstPartyForCookiesRemoteCall,
        CfxRequestGetFlagsRemoteCall,
        CfxRequestGetHeaderMapRemoteCall,
        CfxRequestGetIdentifierRemoteCall,
        CfxRequestGetMethodRemoteCall,
        CfxRequestGetPostDataRemoteCall,
        CfxRequestGetReferrerPolicyRemoteCall,
        CfxRequestGetReferrerUrlRemoteCall,
        CfxRequestGetResourceTypeRemoteCall,
        CfxRequestGetTransitionTypeRemoteCall,
        CfxRequestGetUrlRemoteCall,
        CfxRequestIsReadOnlyRemoteCall,
        CfxRequestSetFirstPartyForCookiesRemoteCall,
        CfxRequestSetFlagsRemoteCall,
        CfxRequestSetHeaderMapRemoteCall,
        CfxRequestSetMethodRemoteCall,
        CfxRequestSetPostDataRemoteCall,
        CfxRequestSetReferrerRemoteCall,
        CfxRequestSetRemoteCall,
        CfxRequestSetUrlRemoteCall,
        CfxResourceBundleGetDataResourceForScaleRemoteCall,
        CfxResourceBundleGetDataResourceRemoteCall,
        CfxResourceBundleGetGlobalRemoteCall,
        CfxResourceBundleGetLocalizedStringRemoteCall,
        CfxResourceBundleHandlerCtorWithGCHandleRemoteCall,
        CfxResourceBundleHandlerGetDataResourceForScaleRemoteEventCall,
        CfxResourceBundleHandlerGetDataResourceRemoteEventCall,
        CfxResourceBundleHandlerGetLocalizedStringRemoteEventCall,
        CfxResourceBundleHandlerSetCallbackRemoteCall,
        CfxResponseCreateRemoteCall,
        CfxResponseGetErrorRemoteCall,
        CfxResponseGetHeaderMapRemoteCall,
        CfxResponseGetHeaderRemoteCall,
        CfxResponseGetMimeTypeRemoteCall,
        CfxResponseGetStatusRemoteCall,
        CfxResponseGetStatusTextRemoteCall,
        CfxResponseIsReadOnlyRemoteCall,
        CfxResponseSetErrorRemoteCall,
        CfxResponseSetHeaderMapRemoteCall,
        CfxResponseSetMimeTypeRemoteCall,
        CfxResponseSetStatusRemoteCall,
        CfxResponseSetStatusTextRemoteCall,
        CfxRuntimeCrashReportingEnabledRemoteCall,
        CfxRuntimeCreateDirectoryRemoteCall,
        CfxRuntimeCreateNewTempDirectoryRemoteCall,
        CfxRuntimeCreateTempDirectoryInDirectoryRemoteCall,
        CfxRuntimeCurrentlyOnRemoteCall,
        CfxRuntimeDeleteFileRemoteCall,
        CfxRuntimeDirectoryExistsRemoteCall,
        CfxRuntimeExecuteProcessRemoteCall,
        CfxRuntimeFormatUrlForSecurityDisplayRemoteCall,
        CfxRuntimeGetTempDirectoryRemoteCall,
        CfxRuntimeIsCertStatusErrorRemoteCall,
        CfxRuntimeIsCertStatusMinorErrorRemoteCall,
        CfxRuntimePostDelayedTaskRemoteCall,
        CfxRuntimePostTaskRemoteCall,
        CfxRuntimeRegisterExtensionRemoteCall,
        CfxRuntimeSetCrashKeyValueRemoteCall,
        CfxRuntimeZipDirectoryRemoteCall,
        CfxSchemeRegistrarAddCustomSchemeRemoteCall,
        CfxStreamReaderCreateForDataRemoteCall,
        CfxStreamReaderCreateForFileRemoteCall,
        CfxStreamReaderCreateForHandlerRemoteCall,
        CfxStreamReaderEofRemoteCall,
        CfxStreamReaderMayBlockRemoteCall,
        CfxStreamReaderReadRemoteCall,
        CfxStreamReaderSeekRemoteCall,
        CfxStreamReaderTellRemoteCall,
        CfxStreamWriterCreateForFileRemoteCall,
        CfxStreamWriterCreateForHandlerRemoteCall,
        CfxStreamWriterFlushRemoteCall,
        CfxStreamWriterMayBlockRemoteCall,
        CfxStreamWriterSeekRemoteCall,
        CfxStreamWriterTellRemoteCall,
        CfxStreamWriterWriteRemoteCall,
        CfxStringVisitorCtorWithGCHandleRemoteCall,
        CfxStringVisitorSetCallbackRemoteCall,
        CfxStringVisitorVisitRemoteEventCall,
        CfxTaskCtorWithGCHandleRemoteCall,
        CfxTaskExecuteRemoteEventCall,
        CfxTaskRunnerBelongsToCurrentThreadRemoteCall,
        CfxTaskRunnerBelongsToThreadRemoteCall,
        CfxTaskRunnerGetForCurrentThreadRemoteCall,
        CfxTaskRunnerGetForThreadRemoteCall,
        CfxTaskRunnerIsSameRemoteCall,
        CfxTaskRunnerPostDelayedTaskRemoteCall,
        CfxTaskRunnerPostTaskRemoteCall,
        CfxTaskSetCallbackRemoteCall,
        CfxThreadCreateRemoteCall,
        CfxThreadGetPlatformThreadIdRemoteCall,
        CfxThreadGetTaskRunnerRemoteCall,
        CfxThreadIsRunningRemoteCall,
        CfxThreadStopRemoteCall,
        CfxTimeCtorRemoteCall,
        CfxTimeDtorRemoteCall,
        CfxTimeGetDayOfMonthRemoteCall,
        CfxTimeGetDayOfWeekRemoteCall,
        CfxTimeGetHourRemoteCall,
        CfxTimeGetMillisecondRemoteCall,
        CfxTimeGetMinuteRemoteCall,
        CfxTimeGetMonthRemoteCall,
        CfxTimeGetSecondRemoteCall,
        CfxTimeGetYearRemoteCall,
        CfxTimeSetDayOfMonthRemoteCall,
        CfxTimeSetDayOfWeekRemoteCall,
        CfxTimeSetHourRemoteCall,
        CfxTimeSetMillisecondRemoteCall,
        CfxTimeSetMinuteRemoteCall,
        CfxTimeSetMonthRemoteCall,
        CfxTimeSetSecondRemoteCall,
        CfxTimeSetYearRemoteCall,
        CfxV8AccessorCtorWithGCHandleRemoteCall,
        CfxV8AccessorGetRemoteEventCall,
        CfxV8AccessorSetCallbackRemoteCall,
        CfxV8AccessorSetRemoteEventCall,
        CfxV8ContextEnterRemoteCall,
        CfxV8ContextEvalRemoteCall,
        CfxV8ContextExitRemoteCall,
        CfxV8ContextGetBrowserRemoteCall,
        CfxV8ContextGetCurrentContextRemoteCall,
        CfxV8ContextGetEnteredContextRemoteCall,
        CfxV8ContextGetFrameRemoteCall,
        CfxV8ContextGetGlobalRemoteCall,
        CfxV8ContextGetTaskRunnerRemoteCall,
        CfxV8ContextInContextRemoteCall,
        CfxV8ContextIsSameRemoteCall,
        CfxV8ContextIsValidRemoteCall,
        CfxV8ExceptionGetEndColumnRemoteCall,
        CfxV8ExceptionGetEndPositionRemoteCall,
        CfxV8ExceptionGetLineNumberRemoteCall,
        CfxV8ExceptionGetMessageRemoteCall,
        CfxV8ExceptionGetScriptResourceNameRemoteCall,
        CfxV8ExceptionGetSourceLineRemoteCall,
        CfxV8ExceptionGetStartColumnRemoteCall,
        CfxV8ExceptionGetStartPositionRemoteCall,
        CfxV8HandlerCtorWithGCHandleRemoteCall,
        CfxV8HandlerExecuteRemoteEventCall,
        CfxV8HandlerSetCallbackRemoteCall,
        CfxV8InterceptorCtorWithGCHandleRemoteCall,
        CfxV8InterceptorGetByIndexRemoteEventCall,
        CfxV8InterceptorGetByNameRemoteEventCall,
        CfxV8InterceptorSetByIndexRemoteEventCall,
        CfxV8InterceptorSetByNameRemoteEventCall,
        CfxV8InterceptorSetCallbackRemoteCall,
        CfxV8StackFrameGetColumnRemoteCall,
        CfxV8StackFrameGetFunctionNameRemoteCall,
        CfxV8StackFrameGetLineNumberRemoteCall,
        CfxV8StackFrameGetScriptNameOrSourceUrlRemoteCall,
        CfxV8StackFrameGetScriptNameRemoteCall,
        CfxV8StackFrameIsConstructorRemoteCall,
        CfxV8StackFrameIsEvalRemoteCall,
        CfxV8StackFrameIsValidRemoteCall,
        CfxV8StackTraceGetCurrentRemoteCall,
        CfxV8StackTraceGetFrameCountRemoteCall,
        CfxV8StackTraceGetFrameRemoteCall,
        CfxV8StackTraceIsValidRemoteCall,
        CfxV8ValueAdjustExternallyAllocatedMemoryRemoteCall,
        CfxV8ValueClearExceptionRemoteCall,
        CfxV8ValueCreateArrayRemoteCall,
        CfxV8ValueCreateBoolRemoteCall,
        CfxV8ValueCreateDateRemoteCall,
        CfxV8ValueCreateDoubleRemoteCall,
        CfxV8ValueCreateFunctionRemoteCall,
        CfxV8ValueCreateIntRemoteCall,
        CfxV8ValueCreateNullRemoteCall,
        CfxV8ValueCreateObjectRemoteCall,
        CfxV8ValueCreateStringRemoteCall,
        CfxV8ValueCreateUintRemoteCall,
        CfxV8ValueCreateUndefinedRemoteCall,
        CfxV8ValueDeleteValueByIndexRemoteCall,
        CfxV8ValueDeleteValueByKeyRemoteCall,
        CfxV8ValueExecuteFunctionRemoteCall,
        CfxV8ValueExecuteFunctionWithContextRemoteCall,
        CfxV8ValueGetArrayLengthRemoteCall,
        CfxV8ValueGetBoolValueRemoteCall,
        CfxV8ValueGetDateValueRemoteCall,
        CfxV8ValueGetDoubleValueRemoteCall,
        CfxV8ValueGetExceptionRemoteCall,
        CfxV8ValueGetExternallyAllocatedMemoryRemoteCall,
        CfxV8ValueGetFunctionHandlerRemoteCall,
        CfxV8ValueGetFunctionNameRemoteCall,
        CfxV8ValueGetIntValueRemoteCall,
        CfxV8ValueGetKeysRemoteCall,
        CfxV8ValueGetStringValueRemoteCall,
        CfxV8ValueGetUintValueRemoteCall,
        CfxV8ValueGetUserDataRemoteCall,
        CfxV8ValueGetValueByIndexRemoteCall,
        CfxV8ValueGetValueByKeyRemoteCall,
        CfxV8ValueHasExceptionRemoteCall,
        CfxV8ValueHasValueByIndexRemoteCall,
        CfxV8ValueHasValueByKeyRemoteCall,
        CfxV8ValueIsArrayRemoteCall,
        CfxV8ValueIsBoolRemoteCall,
        CfxV8ValueIsDateRemoteCall,
        CfxV8ValueIsDoubleRemoteCall,
        CfxV8ValueIsFunctionRemoteCall,
        CfxV8ValueIsIntRemoteCall,
        CfxV8ValueIsNullRemoteCall,
        CfxV8ValueIsObjectRemoteCall,
        CfxV8ValueIsSameRemoteCall,
        CfxV8ValueIsStringRemoteCall,
        CfxV8ValueIsUintRemoteCall,
        CfxV8ValueIsUndefinedRemoteCall,
        CfxV8ValueIsUserCreatedRemoteCall,
        CfxV8ValueIsValidRemoteCall,
        CfxV8ValueSetRethrowExceptionsRemoteCall,
        CfxV8ValueSetUserDataRemoteCall,
        CfxV8ValueSetValueByAccessorRemoteCall,
        CfxV8ValueSetValueByIndexRemoteCall,
        CfxV8ValueSetValueByKeyRemoteCall,
        CfxV8ValueWillRethrowExceptionsRemoteCall,
        CfxValueCopyRemoteCall,
        CfxValueCreateRemoteCall,
        CfxValueGetBinaryRemoteCall,
        CfxValueGetBoolRemoteCall,
        CfxValueGetDictionaryRemoteCall,
        CfxValueGetDoubleRemoteCall,
        CfxValueGetIntRemoteCall,
        CfxValueGetListRemoteCall,
        CfxValueGetStringRemoteCall,
        CfxValueGetTypeRemoteCall,
        CfxValueIsEqualRemoteCall,
        CfxValueIsOwnedRemoteCall,
        CfxValueIsReadOnlyRemoteCall,
        CfxValueIsSameRemoteCall,
        CfxValueIsValidRemoteCall,
        CfxValueSetBinaryRemoteCall,
        CfxValueSetBoolRemoteCall,
        CfxValueSetDictionaryRemoteCall,
        CfxValueSetDoubleRemoteCall,
        CfxValueSetIntRemoteCall,
        CfxValueSetListRemoteCall,
        CfxValueSetNullRemoteCall,
        CfxValueSetStringRemoteCall,
        CfxWaitableEventCreateRemoteCall,
        CfxWaitableEventIsSignaledRemoteCall,
        CfxWaitableEventResetRemoteCall,
        CfxWaitableEventSignalRemoteCall,
        CfxWaitableEventTimedWaitRemoteCall,
        CfxWaitableEventWaitRemoteCall,
        CfxWriteHandlerCtorWithGCHandleRemoteCall,
        CfxWriteHandlerFlushRemoteEventCall,
        CfxWriteHandlerMayBlockRemoteEventCall,
        CfxWriteHandlerSeekRemoteEventCall,
        CfxWriteHandlerSetCallbackRemoteCall,
        CfxWriteHandlerTellRemoteEventCall,
        CfxWriteHandlerWriteRemoteEventCall,
        CfxXmlReaderCloseRemoteCall,
        CfxXmlReaderCreateRemoteCall,
        CfxXmlReaderGetAttributeByIndexRemoteCall,
        CfxXmlReaderGetAttributeByLNameRemoteCall,
        CfxXmlReaderGetAttributeByQNameRemoteCall,
        CfxXmlReaderGetAttributeCountRemoteCall,
        CfxXmlReaderGetBaseUriRemoteCall,
        CfxXmlReaderGetDepthRemoteCall,
        CfxXmlReaderGetErrorRemoteCall,
        CfxXmlReaderGetInnerXmlRemoteCall,
        CfxXmlReaderGetLineNumberRemoteCall,
        CfxXmlReaderGetLocalNameRemoteCall,
        CfxXmlReaderGetNamespaceUriRemoteCall,
        CfxXmlReaderGetOuterXmlRemoteCall,
        CfxXmlReaderGetPrefixRemoteCall,
        CfxXmlReaderGetQualifiedNameRemoteCall,
        CfxXmlReaderGetTypeRemoteCall,
        CfxXmlReaderGetValueRemoteCall,
        CfxXmlReaderGetXmlLangRemoteCall,
        CfxXmlReaderHasAttributesRemoteCall,
        CfxXmlReaderHasErrorRemoteCall,
        CfxXmlReaderHasValueRemoteCall,
        CfxXmlReaderIsEmptyElementRemoteCall,
        CfxXmlReaderMoveToAttributeByIndexRemoteCall,
        CfxXmlReaderMoveToAttributeByLNameRemoteCall,
        CfxXmlReaderMoveToAttributeByQNameRemoteCall,
        CfxXmlReaderMoveToCarryingElementRemoteCall,
        CfxXmlReaderMoveToFirstAttributeRemoteCall,
        CfxXmlReaderMoveToNextAttributeRemoteCall,
        CfxXmlReaderMoveToNextNodeRemoteCall,
        CfxZipReaderCloseFileRemoteCall,
        CfxZipReaderCloseRemoteCall,
        CfxZipReaderCreateRemoteCall,
        CfxZipReaderEofRemoteCall,
        CfxZipReaderGetFileLastModifiedRemoteCall,
        CfxZipReaderGetFileNameRemoteCall,
        CfxZipReaderGetFileSizeRemoteCall,
        CfxZipReaderMoveToFileRemoteCall,
        CfxZipReaderMoveToFirstFileRemoteCall,
        CfxZipReaderMoveToNextFileRemoteCall,
        CfxZipReaderOpenFileRemoteCall,
        CfxZipReaderReadFileRemoteCall,
        CfxZipReaderTellRemoteCall,
        ExecuteProcessRemoteCall,
        FreeGCHandleRemoteCall
    }
}
