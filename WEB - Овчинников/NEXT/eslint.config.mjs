import { dirname } from 'path';
import { fileURLToPath } from 'url';
import { FlatCompat } from '@eslint/eslintrc';
import stylistic from "@stylistic/eslint-plugin";


const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);

const compat = new FlatCompat({
  baseDirectory: __dirname,
  recommendedConfig: {},
});

const eslintConfig = [
  ...compat.extends(
    'next/core-web-vitals',
    'next/typescript',
    'plugin:@typescript-eslint/recommended',
    'plugin:react/recommended',
    'eslint:recommended',
    // 'plugin:@stylistic/recommended', // - не работает
  ),
  ...compat.config({

    env: {
      'browser': true,
      'es2021': true,
      'node': true
    },

    plugins: [
      'react',
      '@typescript-eslint',
      '@stylistic', // - не работает
      // 'stylistic', // если нужно явно
    ],
    
        rules: {
      // ...next.configs.recommended.rules, // Add next.js recommended rules
      //...next.configs.coreWebVitals.rules,  // Add next.js core web vitals rules,
      // ...js.configs.recommended.rules, // Use recommended ruleset
      // ...typescriptEslintPlugin.configs["recommended-type-checked"].rules,  // Enable recommended typescript rules
      ...stylistic.configs.recommended.rules,

      // Stylistic rules (configure these to your preference)
      "@stylistic/semi": ["warn", "always"],
      "@stylistic/indent": ["warn", 2],
      "@stylistic/quotes": ["warn", "single", { avoidEscape: true }],
      "@stylistic/object-curly-spacing": ["error", "always"],
      "@stylistic/array-bracket-spacing": ["error", "never"],
      // "@stylistic/space-before-function-paren": ["error", {
      //   "anonymous": "always",
      //   "named": "always",
      //   // "asyncArrow": "never",
      //   "catch": "always"
      // }],  // consistent with airbnb style guide

      // React specific rules
      "react/jsx-uses-react": "off",
      "react/react-in-jsx-scope": "off",  // Next.js doesn't require importing React
      "react/prop-types": "off", // TS handles prop types

      // Next.js specific rules - configure as needed.
      "next/link-passhref": "off", // You might not want this rule

      // Possible Errors
      "no-console": "off", //  or "error" depending on your preference


      // Best Practices
      eqeqeq: "error", // Enforce strict equality === and !==
      "no-unused-vars": "warn", // Or "error"
      "no-shadow": "off", // Typescript handles shadowing better.
      "@typescript-eslint/no-shadow": "error", //  Enable shadowing rules.
      "@typescript-eslint/explicit-function-return-type": "error",
      "@typescript-eslint/triple-slash-reference": "off",

      // TypeScript specific rules
      "@typescript-eslint/consistent-type-imports": [
        "warn",
        {
          prefer: "type-imports",
          fixStyle: "inline-type-imports",
        },
      ],
      "@typescript-eslint/no-unused-vars": "warn", // Or "error"

      // Override JS rules where needed for TS
      "no-undef": "off", //  typescript handles this

      "@stylistic/member-delimiter-style": [
        "warn",
        {
          "multiline": {
            "delimiter": "semi",
            "requireLast": true
          },
          "singleline": {
            "delimiter": "semi",
            "requireLast": false
          },
          "multilineDetection": "brackets"
        }

      ],
    },


    // rules: {
    //   indent: ['warn', 2],
    //   quotes: ['warn', 'single'],
    //   semi: ['warn', 'always'],
    //   'comma-spacing': ['warn', { before: false, after: true }],
    //   'import/order': [
    //     'warn',
    //     {
    //       'newlines-between': 'always',
    //       groups: [
    //         'builtin',
    //         'external',
    //         'internal',
    //         'parent',
    //         'sibling',
    //         'index',
    //         'object',
    //         'type',
    //       ],
    //     },
    //   ],
    // }
  }),
];

export default eslintConfig;
