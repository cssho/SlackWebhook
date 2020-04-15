# SlackWebhook

Simple slack webhook client.

## Install

```
dotnet tool install -g SlackWebhookCli
```

## Useage

```
$ slack-webhook -url https://hooks.slack.com/services/XXXXX/YYYYY/zzzzzzzzzzzzzzzzzz -text "Hello, Slack!"

$ cat hello.txt | slack-webhook -url https://hooks.slack.com/services/XXXXX/YYYYY/zzzzzzzzzzzzzzzzzz

$ slack-webhook -url https://hooks.slack.com/services/XXXXX/YYYYY/zzzzzzzzzzzzzzzzzz \
                -text "Hello, Slack!" \
                -channel "#dotnet" \
                -userName "cssho"
```
