(window.webpackJsonp=window.webpackJsonp||[]).push([[43],{"./app/gamma/src/components/popovers/header-create-menu/HeaderCreateMenu.less":function(e,t,a){var n=a("./node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js"),r=a("./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/gamma/src/components/popovers/header-create-menu/HeaderCreateMenu.less");"string"==typeof(r=r.__esModule?r.default:r)&&(r=[[e.i,r,""]]);var o={insert:"head",singleton:!1};n(r,o);e.exports=r.locals||{}},"./app/gamma/src/components/popovers/header-create-menu/index.tsx":function(e,t,a){"use strict";a.r(t),a.d(t,"HeaderCreateMenu",(function(){return N}));var n=a("./packages/browser/index.ts"),r=a("./packages/nachos/icons/board.tsx"),o=a("./packages/nachos/icons/template-board.tsx"),s=a("./packages/nachos/icons/organization.tsx"),i=a("./packages/nachos/icons/business-class.tsx"),c=a("./packages/nachos/icons/enterprise.tsx"),l=a("./app/src/components/PopoverMenu/index.ts"),u=a("./app/gamma/src/modules/state/ui/overlay.ts"),d=a("./app/gamma/src/modules/state/ui/create-menu.ts"),p=a("./app/gamma/src/modules/state/models/teams.ts"),m=a("./node_modules/react/index.js"),f=a.n(m),g=a("./node_modules/react-redux/es/index.js"),b=a("./app/gamma/src/selectors/enterprises.ts"),v=a("./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.tsx"),h=a("./packages/feature-flag-client/index.ts"),y=a("./packages/test-ids/index.ts"),_=a("./app/common/lib/util/i18n/index.ts"),x=a("./packages/atlassian-analytics/index.ts"),w=a("./app/scripts/db/auth.js"),j=a.n(w),I=a("./app/gamma/src/components/popovers/header-create-menu/HeaderCreateMenu.less"),C=a.n(I);function k(e,t){if(!(e instanceof t))throw new TypeError("Cannot call a class as a function")}function M(e,t){for(var a=0;a<t.length;a++){var n=t[a];n.enumerable=n.enumerable||!1,n.configurable=!0,"value"in n&&(n.writable=!0),Object.defineProperty(e,n.key,n)}}function T(e,t){return(T=Object.setPrototypeOf||function(e,t){return e.__proto__=t,e})(e,t)}function A(e,t){return!t||"object"!=typeof t&&"function"!=typeof t?function(e){if(void 0===e)throw new ReferenceError("this hasn't been initialised - super() hasn't been called");return e}(e):t}function E(){if("undefined"==typeof Reflect||!Reflect.construct)return!1;if(Reflect.construct.sham)return!1;if("function"==typeof Proxy)return!0;try{return Date.prototype.toString.call(Reflect.construct(Date,[],(function(){}))),!0}catch(e){return!1}}function O(e){return(O=Object.setPrototypeOf?Object.getPrototypeOf:function(e){return e.__proto__||Object.getPrototypeOf(e)})(e)}var S=Object(_.forTemplate)("header_add_menu"),N=function(e){!function(e,t){if("function"!=typeof t&&null!==t)throw new TypeError("Super expression must either be null or a function");e.prototype=Object.create(t&&t.prototype,{constructor:{value:e,writable:!0,configurable:!0}}),t&&T(e,t)}(g,e);var t,a,n,d,m=(t=g,function(){var e,a=O(t);if(E()){var n=O(this).constructor;e=Reflect.construct(a,arguments,n)}else e=a.apply(this,arguments);return A(this,e)});function g(){return k(this,g),m.apply(this,arguments)}return a=g,(n=[{key:"componentDidMount",value:function(){this.props.onMount(),Object(v.b)()}},{key:"showOverlayWithTracking",value:function(e,t){var a=this.props,n=a.onClickCreateItem,r=a.onCreateBoardOverlayShown,o=a.onCreateTeamOverlayShown;e===u.OverlayType.CreateBoard?(x.Analytics.sendUIEvent({action:"clicked",actionSubject:"menuItem",actionSubjectId:"createBoardMenuItem",source:"createMenuInlineDialog"}),r()):e===u.OverlayType.CreateTeam&&(t===p.a.Business&&x.Analytics.sendUIEvent({action:"clicked",actionSubject:"menuItem",actionSubjectId:"createBCTeamMenuItem",source:"createMenuInlineDialog"}),t===p.a.Default&&x.Analytics.sendUIEvent({action:"clicked",actionSubject:"menuItem",actionSubjectId:"createFreeTeamMenuItem",source:"createMenuInlineDialog"}),o()),n(e,t)}},{key:"render",value:function(){var e=this,t=this.props,a=t.enableEnterpriseAdd,n=t.isEnterpriseManaged,d=t.onClickCreateEnterpriseTeam,m=t.onClickCreateBoardFromTemplate,g=t.isDesktop,b=h.featureFlagClient.get("fv.domain-level-free-team-restricted",!1),v=!n,_=!g&&!(n||b),w=!!a,I=j.a.me().isDismissed("start-with-a-template")?S("start-with-a-template"):f.a.createElement("span",{className:C.a.newPillContainer},S("start-with-a-template"),f.a.createElement("span",{className:C.a.newPill},S("new")));return f.a.createElement(l.a,null,f.a.createElement(l.b,{description:S("a-board-is-made-up-of-cards-ordered-on-lists"),onClick:function(){e.showOverlayWithTracking(u.OverlayType.CreateBoard)},title:S("create-board"),testId:y.HeaderTestIds.CreateBoardButton,icon:f.a.createElement(r.BoardIcon,{dangerous_className:C.a.headerCreateIcon})}),f.a.createElement(l.b,{description:S("get-started-faster"),onClick:function(){x.Analytics.sendUIEvent({action:"clicked",actionSubject:"menuItem",actionSubjectId:"startWithTemplateMenuItem",source:"createMenuInlineDialog"}),m()},title:I,testId:y.HeaderTestIds.CreateBoardFromTemplateButton,icon:f.a.createElement(o.a,{dangerous_className:C.a.headerCreateIcon})}),v&&f.a.createElement(l.b,{onClick:function(){e.showOverlayWithTracking(u.OverlayType.CreateTeam,p.a.Default)},description:S("a-team-is-a-group-of-boards-and-people"),title:S("create-team"),testId:y.HeaderTestIds.CreateTeamButton,icon:f.a.createElement(s.a,{dangerous_className:C.a.headerCreateIcon})}),_&&f.a.createElement(l.b,{onClick:function(){e.showOverlayWithTracking(u.OverlayType.CreateTeam,p.a.Business)},description:S("with-business-class-your-team-has-more"),title:S("create-business-team"),testId:y.HeaderTestIds.CreateBusinessTeamButton,icon:f.a.createElement(i.BusinessClassIcon,{dangerous_className:C.a.headerCreateIcon})}),w&&f.a.createElement(l.b,{onClick:function(){x.Analytics.sendUIEvent({action:"clicked",actionSubject:"menuItem",actionSubjectId:"createEnterpriseTeamMenuItem",source:"createMenuInlineDialog"}),d()},description:S("your-team-will-be-owned-by-an-enterprise"),title:S("create-enterprise-team"),testId:y.HeaderTestIds.CreateEnterpriseTeamButton,icon:f.a.createElement(c.a,{dangerous_className:C.a.headerCreateIcon})}))}}])&&M(a.prototype,n),d&&M(a,d),g}(f.a.Component);t.default=Object(g.c)((function(e){return{enableEnterpriseAdd:Object(b.e)(e),isEnterpriseManaged:Object(b.j)(e),isDesktop:Object(n.isDesktop)()}}),(function(e){return{onClickCreateItem(t,a){e(Object(u.setOverlay)({overlayType:t,teamType:a}))},onMount(){e(Object(d.preloadCreateBoardData)())}}}))(N)},"./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.less":function(e,t,a){var n=a("./node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js"),r=a("./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.less");"string"==typeof(r=r.__esModule?r.default:r)&&(r=[[e.i,r,""]]);var o={insert:"head",singleton:!1};n(r,o);e.exports=r.locals||{}},"./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.tsx":function(e,t,a){"use strict";a.d(t,"b",(function(){return v})),a.d(t,"a",(function(){return h}));var n=a("./node_modules/classnames/index.js"),r=a.n(n),o=a("./node_modules/react/index.js"),s=a.n(o),i=a("./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.less"),c=a.n(i);function l(e,t){return function(e){if(Array.isArray(e))return e}(e)||function(e,t){if("undefined"==typeof Symbol||!(Symbol.iterator in Object(e)))return;var a=[],n=!0,r=!1,o=void 0;try{for(var s,i=e[Symbol.iterator]();!(n=(s=i.next()).done)&&(a.push(s.value),!t||a.length!==t);n=!0);}catch(e){r=!0,o=e}finally{try{n||null==i.return||i.return()}finally{if(r)throw o}}return a}(e,t)||function(e,t){if(!e)return;if("string"==typeof e)return u(e,t);var a=Object.prototype.toString.call(e).slice(8,-1);"Object"===a&&e.constructor&&(a=e.constructor.name);if("Map"===a||"Set"===a)return Array.from(a);if("Arguments"===a||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(a))return u(e,t)}(e,t)||function(){throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function u(e,t){(null==t||t>e.length)&&(t=e.length);for(var a=0,n=new Array(t);a<t;a++)n[a]=e[a];return n}var d=a("./resources/images/organization/empty-board.svg"),p=a("./resources/images/organization/green-face.svg"),m=a("./resources/images/organization/blue-face.svg"),f=a("./resources/images/organization/purple-face.svg"),g=a("./resources/images/organization/red-face.svg"),b=a("./resources/images/create-team/wavy-border.svg"),v=function(){(new Image).src=d,(new Image).src=p,(new Image).src=m,(new Image).src=f,(new Image).src=g,(new Image).src=b},h=function(e){var t=e.animationStep,a=l(Object(o.useState)(!1),2),n=a[0],i=a[1];return Object(o.useEffect)((function(){t>4&&(i(!0),setTimeout((function(){return i(!1)}),2e3))}),[t]),s.a.createElement("div",{className:c.a.illustrationWrapper},s.a.createElement("img",{width:342,height:256,src:d,alt:"",role:"presentation"}),s.a.createElement("img",{className:t>0?r()(c.a.greenFaceVisible,{[c.a.greenFaceWiggle]:n}):c.a.greenFaceHidden,src:p,alt:"",role:"presentation"}),s.a.createElement("img",{className:t>1?r()(c.a.redFaceVisible,{[c.a.redFaceWiggle]:n}):c.a.redFaceHidden,src:g,alt:"",role:"presentation"}),s.a.createElement("img",{className:t>2?r()(c.a.blueFaceVisible,{[c.a.blueFaceWiggle]:n}):c.a.blueFaceHidden,src:m,alt:"",role:"presentation"}),s.a.createElement("img",{className:t>3?r()(c.a.purpleFaceVisible,{[c.a.purpleFaceWiggle]:n}):c.a.purpleFaceHidden,src:f,alt:"",role:"presentation"}))}},"./app/src/components/PopoverMenu/PopoverMenu.less":function(e,t,a){var n=a("./node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js"),r=a("./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/src/components/PopoverMenu/PopoverMenu.less");"string"==typeof(r=r.__esModule?r.default:r)&&(r=[[e.i,r,""]]);var o={insert:"head",singleton:!1};n(r,o);e.exports=r.locals||{}},"./app/src/components/PopoverMenu/index.ts":function(e,t,a){"use strict";a.d(t,"a",(function(){return _})),a.d(t,"b",(function(){return y})),a.d(t,"c",(function(){return h}));var n=a("./node_modules/classnames/index.js"),r=a.n(n),o=a("./app/common/lib/util/forward-ref-component.ts"),s=a("./app/common/components/singlespa/router-link.tsx"),i=a("./node_modules/react/index.js"),c=a.n(i),l=a("./app/src/components/PopoverMenu/PopoverMenu.less"),u=a.n(l),d=a("./packages/a11y/index.ts");function p(){return(p=Object.assign||function(e){for(var t=1;t<arguments.length;t++){var a=arguments[t];for(var n in a)Object.prototype.hasOwnProperty.call(a,n)&&(e[n]=a[n])}return e}).apply(this,arguments)}function m(e,t){return function(e){if(Array.isArray(e))return e}(e)||function(e,t){if("undefined"==typeof Symbol||!(Symbol.iterator in Object(e)))return;var a=[],n=!0,r=!1,o=void 0;try{for(var s,i=e[Symbol.iterator]();!(n=(s=i.next()).done)&&(a.push(s.value),!t||a.length!==t);n=!0);}catch(e){r=!0,o=e}finally{try{n||null==i.return||i.return()}finally{if(r)throw o}}return a}(e,t)||function(e,t){if(!e)return;if("string"==typeof e)return f(e,t);var a=Object.prototype.toString.call(e).slice(8,-1);"Object"===a&&e.constructor&&(a=e.constructor.name);if("Map"===a||"Set"===a)return Array.from(a);if("Arguments"===a||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(a))return f(e,t)}(e,t)||function(){throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function f(e,t){(null==t||t>e.length)&&(t=e.length);for(var a=0,n=new Array(t);a<t;a++)n[a]=e[a];return n}function g(e,t){if(null==e)return{};var a,n,r=function(e,t){if(null==e)return{};var a,n,r={},o=Object.keys(e);for(n=0;n<o.length;n++)a=o[n],t.indexOf(a)>=0||(r[a]=e[a]);return r}(e,t);if(Object.getOwnPropertySymbols){var o=Object.getOwnPropertySymbols(e);for(n=0;n<o.length;n++)a=o[n],t.indexOf(a)>=0||Object.prototype.propertyIsEnumerable.call(e,a)&&(r[a]=e[a])}return r}var b=function(e){var t=e.children,a=e.description,n=e.rawDescription,o=e.title,s=e.icon;return c.a.createElement(c.a.Fragment,null,s&&c.a.cloneElement(s,{size:"small"}),c.a.createElement("span",{className:r()(u.a.title,a&&u.a.withoutMargins)},o||t),(a||n)&&c.a.createElement("p",{className:u.a.description},a||n))},v=function(e){var t=e.appendSeparator,a=e.children;return c.a.createElement("li",{className:r()(u.a.item,t&&u.a.withSeparator)},a)},h=function(e){var t=e.appendSeparator,a=e.testId,n=e.href,o=e.target,i=e.className,l=e.onClick,f=g(e,["appendSeparator","testId","href","target","className","onClick"]),h=m(Object(d.a)(),2),y=h[0],_=h[1];return c.a.createElement(v,{appendSeparator:t},c.a.createElement(s.a,p({className:r()(u.a.link,i,y&&u.a.linkFocusRing),href:n,testId:a,onClick:l,target:o},_),c.a.createElement(b,f)))},y=Object(o.a)("PopoverMenuButton",(function(e,t){var a=e.appendSeparator,n=e.onClick,o=e.className,s=e.disabled,i=e.testId,l=g(e,["appendSeparator","onClick","className","disabled","testId"]),f=m(Object(d.a)(),2),h=f[0],y=f[1];return c.a.createElement(v,{appendSeparator:a},c.a.createElement("button",p({className:r()(u.a.link,h&&u.a.linkFocusRing,o),disabled:s,onClick:n,"data-test-id":i,ref:t},y),c.a.createElement(b,l)))})),_=function(e){var t=e.className,a=e.children,n=e.testId;return c.a.createElement("nav",{className:t},c.a.createElement("ul",{"data-test-id":n},a))}},"./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/gamma/src/components/popovers/header-create-menu/HeaderCreateMenu.less":function(e,t,a){(t=e.exports=a("./node_modules/css-loader/lib/css-base.js")(!1)).push([e.i,"._2mMNV8tvwR-cHM{display:inline-flex;align-items:center}._3rM4orMzIrwz3K{background-color:#61bd4f;border-radius:20px;color:#fff;font-size:12px;font-weight:400;line-height:20px;padding:1px 10px;text-align:center;margin-left:8px}._2UhigD6gogjYy6{display:inline-flex;align-items:center;height:20px;width:20px}",""]),t.locals={newPillContainer:"_2mMNV8tvwR-cHM",newPill:"_3rM4orMzIrwz3K",headerCreateIcon:"_2UhigD6gogjYy6"}},"./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/scripts/views/organization/InviteTeamMembers/TeamIllustrationAnimation.less":function(e,t,a){(t=e.exports=a("./node_modules/css-loader/lib/css-base.js")(!1)).push([e.i,"._3qyYZ_ffqe5APT{flex:0 0 auto;height:256px;width:342px}._3qyYZ_ffqe5APT ._1ZDrdsuKzdWg_4{opacity:0;position:absolute;transform:translateX(-100px) translateY(290px) scale(.1)}._3qyYZ_ffqe5APT ._38N6-KzLeXexiF{position:absolute;opacity:1;transition:transform .25s ease-in-out,opacity .3s;animation-fill-mode:forwards;height:50px;width:50px;transform:translateX(-180px) translateY(220px) scale(1)}._3qyYZ_ffqe5APT ._2maZpb1v3cmaKM{animation-direction:alternate-reverse;animation-duration:.34s;animation-iteration-count:5;animation-name:_3NnxGiyjTko2_7;margin-left:-180px;margin-top:220px}._3qyYZ_ffqe5APT ._2AfucOdcPC0oXo{opacity:0;position:absolute;transform:translateX(20px) translateY(135px) scale(.1)}._3qyYZ_ffqe5APT .I3IqQit5H-SlYI{position:absolute;opacity:1;transition:transform .25s ease-in-out,opacity .3s;animation-fill-mode:forwards;height:55px;width:55px;transform:translateX(-65px) translateY(135px) scale(1)}._3qyYZ_ffqe5APT ._83_k2C9R-wTRps{animation-direction:alternate;animation-duration:.34s;animation-iteration-count:5;animation-name:_1AKuGPC6g5PgUi;margin-left:-65px;margin-top:135px}._3qyYZ_ffqe5APT ._3mOaNaiDiY3qs_{opacity:0;position:absolute;transform:translateX(-75px) translateY(-90px) scale(.1)}._3qyYZ_ffqe5APT ._2lK92dM_037E-T{position:absolute;opacity:1;transition:transform .25s ease-in-out,opacity .3s;animation-fill-mode:forwards;height:40px;width:40px;transform:translateX(-115px) translateY(22px) scale(1)}._3qyYZ_ffqe5APT ._391_v_QHBld16i{animation-direction:alternate-reverse;animation-duration:.34s;animation-iteration-count:5;animation-name:_3NnxGiyjTko2_7;margin-left:-115px;margin-top:22px}._3qyYZ_ffqe5APT ._2RcUIa4UOzSlM6{opacity:0;position:absolute;transform:translateX(-550px) translateY(260px) scale(.1)}._3qyYZ_ffqe5APT ._2kERTJdH-fq4Hp{position:absolute;opacity:1;transition:transform .25s ease-in-out,opacity .3s;animation-fill-mode:forwards;height:85px;width:85px;transform:translateX(-335px) translateY(160px) scale(1)}._3qyYZ_ffqe5APT .VOJVeX74e-gwgf{animation-direction:alternate;animation-duration:.34s;animation-iteration-count:5;animation-name:_1AKuGPC6g5PgUi;margin-left:-335px;margin-top:160px}@keyframes _1AKuGPC6g5PgUi{0%,to{animation-timing-function:ease-in-out;transform:rotate(0deg)}50%{animation-timing-function:ease-in-out;transform:rotate(-20deg)}}@keyframes _3NnxGiyjTko2_7{0%,to{animation-timing-function:ease-in-out;transform:rotate(0deg)}50%{animation-timing-function:ease-in-out;transform:rotate(20deg)}}",""]),t.locals={illustrationWrapper:"_3qyYZ_ffqe5APT",purpleFaceHidden:"_1ZDrdsuKzdWg_4",purpleFaceVisible:"_38N6-KzLeXexiF",purpleFaceWiggle:"_2maZpb1v3cmaKM",wiggleForward:"_3NnxGiyjTko2_7",redFaceHidden:"_2AfucOdcPC0oXo",redFaceVisible:"I3IqQit5H-SlYI",redFaceWiggle:"_83_k2C9R-wTRps",wiggleBackward:"_1AKuGPC6g5PgUi",blueFaceHidden:"_3mOaNaiDiY3qs_",blueFaceVisible:"_2lK92dM_037E-T",blueFaceWiggle:"_391_v_QHBld16i",greenFaceHidden:"_2RcUIa4UOzSlM6",greenFaceVisible:"_2kERTJdH-fq4Hp",greenFaceWiggle:"VOJVeX74e-gwgf"}},"./node_modules/css-loader/index.js?!./node_modules/postcss-loader/src/index.js?!./node_modules/less-loader/dist/cjs.js?!./app/src/components/PopoverMenu/PopoverMenu.less":function(e,t,a){(t=e.exports=a("./node_modules/css-loader/lib/css-base.js")(!1)).push([e.i,'._2FCfpANq784raH{background-color:transparent;border:none;background:#fff;border-radius:0;box-shadow:none;color:#172b4d;display:block;height:100%;padding:6px 12px;text-align:left;text-decoration:none;width:100%;transition:none;margin:0;outline:0}._2FCfpANq784raH:hover{background-color:transparent;border:none;box-shadow:none;background:rgba(9,30,66,.04)}._2FCfpANq784raH:active{background-color:transparent;border:none;box-shadow:none;background:#e4f0f6}._2FCfpANq784raH._154-yjtGZB4imr:focus{outline:1px dotted #000}@media screen and (-webkit-min-device-pixel-ratio:0){._2FCfpANq784raH._154-yjtGZB4imr:focus{outline:5px auto -webkit-focus-ring-color}}._2FCfpANq784raH[disabled]:active,._2FCfpANq784raH[disabled]:focus,._2FCfpANq784raH[disabled]:hover{background:transparent;color:#a5adba!important}._2FCfpANq784raH[disabled]:active ._3oK2g02ecSZ4wX svg,._2FCfpANq784raH[disabled]:focus ._3oK2g02ecSZ4wX svg,._2FCfpANq784raH[disabled]:hover ._3oK2g02ecSZ4wX svg{color:#a5adba!important}._2FCfpANq784raH[disabled]:active span[name=check],._2FCfpANq784raH[disabled]:focus span[name=check],._2FCfpANq784raH[disabled]:hover span[name=check]{color:#6b778c!important}._2FCfpANq784raH[disabled]:active .Puvhv7-oGbJGmR,._2FCfpANq784raH[disabled]:focus .Puvhv7-oGbJGmR,._2FCfpANq784raH[disabled]:hover .Puvhv7-oGbJGmR{color:#a5adba!important}.lcLi2SyiMFND91{font-size:14px;font-weight:400;line-height:20px}.lcLi2SyiMFND91._27ZbL25GrWr6E2{margin:0}.Puvhv7-oGbJGmR{color:#5e6c84;font-size:12px;font-weight:400;line-height:16px;margin:4px 0 0;padding:0}._1IJ3BWdWDb2xH2:after{background-color:rgba(9,30,66,.13);content:" ";display:block;height:1px;margin:8px auto;width:calc(100% - 20px)}',""]),t.locals={link:"_2FCfpANq784raH",linkFocusRing:"_154-yjtGZB4imr",icon:"_3oK2g02ecSZ4wX",description:"Puvhv7-oGbJGmR",title:"lcLi2SyiMFND91",withoutMargins:"_27ZbL25GrWr6E2",withSeparator:"_1IJ3BWdWDb2xH2"}},"./packages/a11y/index.ts":function(e,t,a){"use strict";a.d(t,"a",(function(){return s}));var n=a("./node_modules/react/index.js");function r(e,t){return function(e){if(Array.isArray(e))return e}(e)||function(e,t){if("undefined"==typeof Symbol||!(Symbol.iterator in Object(e)))return;var a=[],n=!0,r=!1,o=void 0;try{for(var s,i=e[Symbol.iterator]();!(n=(s=i.next()).done)&&(a.push(s.value),!t||a.length!==t);n=!0);}catch(e){r=!0,o=e}finally{try{n||null==i.return||i.return()}finally{if(r)throw o}}return a}(e,t)||function(e,t){if(!e)return;if("string"==typeof e)return o(e,t);var a=Object.prototype.toString.call(e).slice(8,-1);"Object"===a&&e.constructor&&(a=e.constructor.name);if("Map"===a||"Set"===a)return Array.from(a);if("Arguments"===a||/^(?:Ui|I)nt(?:8|16|32)(?:Clamped)?Array$/.test(a))return o(e,t)}(e,t)||function(){throw new TypeError("Invalid attempt to destructure non-iterable instance.\nIn order to be iterable, non-array objects must have a [Symbol.iterator]() method.")}()}function o(e,t){(null==t||t>e.length)&&(t=e.length);for(var a=0,n=new Array(t);a<t;a++)n[a]=e[a];return n}var s=function(){var e=arguments.length>0&&void 0!==arguments[0]?arguments[0]:{},t=Object(n.useState)(!1),a=r(t,2),o=a[0],s=a[1],i=Object(n.useState)(!1),c=r(i,2),l=c[0],u=c[1],d=Object(n.useState)(!1),p=r(d,2),m=p[0],f=p[1],g=function(){l&&m||s(!0)},b={onMouseEnter:function(t){u(!0),s(!1),e.onMouseEnter&&e.onMouseEnter(t)},onMouseLeave:function(t){u(!1),s(!1),e.onMouseLeave&&e.onMouseLeave(t)},onMouseDown:function(t){f(!0),s(!1),e.onMouseDown&&e.onMouseDown(t)},onKeyDown:function(t){f(!1),g(),e.onKeyDown&&e.onKeyDown(t)},onKeyUp:function(t){g(),e.onKeyUp&&e.onKeyUp(t)},onBlur:function(t){s(!1),e.onBlur&&e.onBlur(t)}};return[o,b]}},"./packages/nachos/icons/business-class.tsx":function(e,t,a){"use strict";a.r(t),a.d(t,"BusinessClassIcon",(function(){return i}));var n=a("./node_modules/react/index.js"),r=a.n(n),o=a("./packages/nachos/src/components/Icon/index.ts"),s=function(){return r.a.createElement("svg",{width:"24",height:"24",role:"presentation",focusable:"false",viewBox:"0 0 24 24"},r.a.createElement("path",{fillRule:"evenodd",clipRule:"evenodd",d:"M7 5a2 2 0 012-2h6a2 2 0 012 2v1h2v14H5V6h2V5zm2 1h6V5H9v1zM7 9a1 1 0 011-1h2a1 1 0 011 1v7a1 1 0 01-1 1H8a1 1 0 01-1-1V9zm7-1a1 1 0 00-1 1v5a1 1 0 001 1h2a1 1 0 001-1V9a1 1 0 00-1-1h-2z",fill:"currentColor"}),r.a.createElement("path",{d:"M4 6a2 2 0 00-2 2v10a2 2 0 002 2V6zm16 14V6a2 2 0 012 2v10a2 2 0 01-2 2z",fill:"currentColor"}))},i=function(e){var t=e.testId,a=e.dangerous_className,n=e.size,i=e.color,c=e.label;return r.a.createElement(o.a,{testId:t,size:n,dangerous_className:a,color:i,label:c||"BusinessClassIcon",glyph:s})}},"./packages/nachos/icons/template-board.tsx":function(e,t,a){"use strict";a.d(t,"a",(function(){return i}));var n=a("./node_modules/react/index.js"),r=a.n(n),o=a("./packages/nachos/src/components/Icon/index.ts"),s=function(){return r.a.createElement("svg",{width:"24",height:"24",role:"presentation",focusable:"false",viewBox:"0 0 24 24"},r.a.createElement("path",{d:"M7 3a1 1 0 011-1h1a1 1 0 010 2H8a1 1 0 01-1-1zM3 7a1 1 0 00-1 1v1a1 1 0 002 0V8a1 1 0 00-1-1zm-1 5a1 1 0 112 0v1a1 1 0 11-2 0v-1zm0 4a1 1 0 112 0v3a2 2 0 01-2-2v-1zM12 2a1 1 0 100 2h1a1 1 0 100-2h-1zm3 1a1 1 0 011-1h1a2 2 0 012 2h-3a1 1 0 01-1-1zM4 2a2 2 0 00-2 2v1a1 1 0 002 0V4h1a1 1 0 000-2H4z",fill:"currentColor"}),r.a.createElement("path",{fillRule:"evenodd",clipRule:"evenodd",d:"M7 5a2 2 0 00-2 2v12a2 2 0 002 2h12a2 2 0 002-2V7a2 2 0 00-2-2H7zm1 2a1 1 0 00-1 1v9a1 1 0 001 1h3a1 1 0 001-1V8a1 1 0 00-1-1H8zm6 1a1 1 0 011-1h3a1 1 0 011 1v5a1 1 0 01-1 1h-3a1 1 0 01-1-1V8z",fill:"currentColor"}))},i=function(e){var t=e.testId,a=e.dangerous_className,n=e.size,i=e.color,c=e.label;return r.a.createElement(o.a,{testId:t,size:n,dangerous_className:a,color:i,label:c||"TemplateBoardIcon",glyph:s})}},"./resources/images/create-team/wavy-border.svg":function(e,t,a){e.exports=a.p+"images/create-team/wavy-border.1ea9c6f8c41d10be0e12.svg"},"./resources/images/organization/blue-face.svg":function(e,t,a){e.exports=a.p+"images/organization/blue-face.a0ee4f9a807f04212231.svg"},"./resources/images/organization/empty-board.svg":function(e,t,a){e.exports=a.p+"images/organization/empty-board.286f8fc83e01c93ed27e.svg"},"./resources/images/organization/green-face.svg":function(e,t,a){e.exports=a.p+"images/organization/green-face.0f4410938f763fec6402.svg"},"./resources/images/organization/purple-face.svg":function(e,t,a){e.exports=a.p+"images/organization/purple-face.ee0f268b424c09fdf633.svg"},"./resources/images/organization/red-face.svg":function(e,t,a){e.exports=a.p+"images/organization/red-face.2861547542157c546553.svg"}}]);
//# sourceMappingURL=create-menu-popover.89fa378288a373bcdb83.js.map